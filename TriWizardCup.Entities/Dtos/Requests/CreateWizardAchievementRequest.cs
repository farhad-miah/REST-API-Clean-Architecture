﻿namespace TriWizardCup.Entities.Dtos.Requests
{
    public class CreateWizardAchievementRequest
    {
        public Guid WizardId { get; set; }
        public int TriWizardCupWins { get; set; }
        public int TotalEnemiesDefeated { get; set; } 
        public int TopThreeFinishes { get; set; }
        public int Wins { get; set; }
    }
}
