﻿using System.Security.Cryptography.X509Certificates;

namespace Mastermind.Models
{
    public class Game
    {
        public Guid Id { get; set; }
        public string PlayerName { get; set; }
        public Code Code { get; set; }
        public Mode GameMode { get; set; }
        public int Chances { get; set; }
        public int? LastScore { get; set; }
    }
    public enum Mode
    {
        ManualSet,
        RandomSet
    }
}
