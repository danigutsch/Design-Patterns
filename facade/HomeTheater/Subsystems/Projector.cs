﻿namespace HomeTheater
{
    public class Projector
    {
        private readonly string _description;
#pragma warning disable IDE0052 // Remove unread private members
        private readonly DvdPlayer _dvdPlayer;
#pragma warning restore IDE0052 // Remove unread private members

        public Projector(string description, DvdPlayer dvdPlayer)
        {
            _description = description;
            _dvdPlayer = dvdPlayer;
        }

        public void On()
        {
            Console.WriteLine($"{_description} on");
        }

        public void Off()
        {
            Console.WriteLine($"{_description} off");
        }

        public void WideScreenMode()
        {
            Console.WriteLine($"{_description} in widescreen mode (16x9 aspect ratio)");
        }

        public void TvMode()
        {
            Console.WriteLine($"{_description} in tv mode (4x3 aspect ratio)");
        }

        public override string ToString()
        {
            return _description;
        }
    }
}