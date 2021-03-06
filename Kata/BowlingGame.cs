﻿using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class BowlingGame
    {
        private int[] rolls = new int[20];
        private int currentRoll = 0;

        public int Score
        {
            get
            {
                var score = 0;
                var rollIndex = 0;
                for (var frame = 0; frame < 10; frame++)
                {
                    if (IsStrike(rollIndex))
                    {
                        score += GetStrikeScore(rollIndex);
                        rollIndex++;
                    }
                    else if (IsSpare(rollIndex))
                    {
                        score += GetSpareScore(rollIndex);
                        rollIndex += 2;
                    }
                    else
                    {
                        score += GetStandarScore(rollIndex);
                        rollIndex += 2;
                    }
                }
                return score;
            }
        }
        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }
        private bool IsSpare(int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1] == 10;
        }
        private bool IsStrike(int rollIndex)
        {
            return rolls[rollIndex] == 10;
        }
        private int GetStandarScore(int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1];
        }
        private int GetSpareScore(int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1] + rolls[rollIndex + 2];
        }
        private int GetStrikeScore(int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1] + rolls[rollIndex + 2];
        }
    }
}
