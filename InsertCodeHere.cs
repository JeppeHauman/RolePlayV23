﻿namespace RolePlayV23
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            CharacterGroup redTeam = new CharacterGroup("Team Red");
            redTeam.AddCharacter(new Character("Angor", 100, 15, 25));
            redTeam.AddCharacter(new Character("Zurin", 85, 18, 30));
            redTeam.AddCharacter(new Defender("Mart", 150, 5, 10 ));
            redTeam.AddCharacter(new Damager("Charlot", 70, 20, 40));

            CharacterGroup greenTeam = new CharacterGroup("Team Green");
            greenTeam.AddCharacter(new Character("Baldur", 120, 12, 18));
            greenTeam.AddCharacter(new Character("Eliza", 80, 20, 35));
            greenTeam.AddCharacter(new Defender("JP", 150, 5, 10 ));
            greenTeam.AddCharacter(new Damager("Vibs", 70, 20, 40));

            BattleHandler.DoBattle(redTeam, greenTeam);

            // The LAST line of code should be ABOVE this line
        }
    }
}