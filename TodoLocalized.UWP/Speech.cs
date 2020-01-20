﻿using System;
using TodoLocalized.UWP;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms;

[assembly: Dependency(typeof(Speech))]
namespace TodoLocalized.UWP
{
    public class Speech : ITextToSpeech
    {
        public async void Speak(string text)
        {
            using (var speech = new SpeechSynthesizer())
            {
                var stream = await speech.SynthesizeTextToStreamAsync(text);
                var mediaElement = new MediaElement();
                mediaElement.SetSource(stream, stream.ContentType);
                mediaElement.Play();
            }
        }
    }
}
