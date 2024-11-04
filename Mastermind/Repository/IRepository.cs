﻿using Mastermind.Models;

namespace Mastermind.Repository
{
    public interface IRepository
    {
        public Task<bool> AddScore(string playerName, int score);
        public Task<bool> UpdateScore(string playerName, int score);
        public Task<int> PlayerHighscore(string playerName);
    }
}