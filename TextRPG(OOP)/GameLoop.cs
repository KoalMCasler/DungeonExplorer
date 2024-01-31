﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_OOP_
{
    internal class GameLoop
    {
        static Player mainPlayer;
        static Enemy firstEnemy;
        static Map gameMap;
        static void Main(string[] args)
        {
            StartUp();
            Console.WriteLine("Welcome to my Text RPG game!");
            Console.WriteLine();
            //Testing v
            // Console.WriteLine("The players HP: " + mainPlayer.healthSystem.health);
            // Console.WriteLine("The Enemies HP: " + firstEnemy.healthSystem.health);
            // mainPlayer.healthSystem.TakeDamage(firstEnemy.enemyDamage);
            // Console.WriteLine(string.Format("{0} took {1} damage from {2}", mainPlayer.playerName, firstEnemy.enemyDamage,firstEnemy.enemyName));
            // firstEnemy.healthSystem.TakeDamage(mainPlayer.playerDamage);
            // Console.WriteLine(string.Format("{0} took {1} damage from {2}", firstEnemy.enemyName, mainPlayer.playerDamage,mainPlayer.playerName));
            // Console.WriteLine("The players HP: " + mainPlayer.healthSystem.health);
            // Console.WriteLine("The Enemies HP: " + firstEnemy.healthSystem.health);
            // mainPlayer.healthSystem.Heal(500, mainPlayer.PlayerMaxHP);
            // Console.WriteLine(string.Format("{0} gained 500, but they only have {1} max HP.",mainPlayer.playerName, mainPlayer.PlayerMaxHP));
            // firstEnemy.healthSystem.Heal(1000, firstEnemy.enemyMaxHP);
            // Console.WriteLine(string.Format("{0} gained 1000, but they only have {1} max HP.",firstEnemy.enemyName, firstEnemy.enemyMaxHP));
            // Console.WriteLine("The players HP: " + mainPlayer.healthSystem.health);
            // Console.WriteLine("The Enemies HP: " + firstEnemy.healthSystem.health);
            // Console.WriteLine(string.Format("{0} has a position of {1}X : {2}Y",mainPlayer.playerName, mainPlayer.position.x,mainPlayer.position.y));
            // Console.WriteLine(string.Format("{0} has a position of {1}X : {2}Y",firstEnemy.enemyName, firstEnemy.position.x, firstEnemy.position.y));
            Console.Write(gameMap.activeMap);
            DrawMap();
            //Testing ^
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
        static void StartUp()
        {
            gameMap = new Map();
            mainPlayer = new Player();
            firstEnemy = new Enemy();
            gameMap.Initialization();
            firstEnemy.enemyName = "Slime";
        }
        static void DrawMap()
        {
            //Draws the map of the current level
            Console.SetCursorPosition(0,0);
            for(int y = 0; y < gameMap.mapY; y++)
            {
                for(int x = 0; x < gameMap.mapX; x++)
                {
                    char tile = gameMap.activeMap[y,x];
                    gameMap.DrawTile(tile);     
                }
                Console.Write("\n");
            }
            Console.SetCursorPosition(0,0);
        }
    }
}
