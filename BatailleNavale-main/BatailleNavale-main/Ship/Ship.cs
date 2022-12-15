﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{

    public class Ship
    {

        /// <summary>
        /// Point de départ du navire
        /// </summary>
        /// 
        public Point ShipStartPointCoordinate { get; set; }

        /// <summary>
        /// Description des états des tableaux par un tableai dont l'index doit être EtatBateau
        /// </summary>
        public readonly static string[] DescriptionEtatBateau = { "intact", "touché", "coulé" };

        public static int Id = 0;
        /// <summary>
        /// Indique l'ID maximale disponible; s'incrémente à chaque création de Ship
        /// </summary>
        public static uint ID_Max { get; set; } = 0;
        /// <summary>
        /// ID du bateau
        /// </summary>
        public uint ID { get; set; }
        /// <summary>
        /// Nom du type du bateau
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Etat du bateau
        /// </summary>
        public ShipState ShipState;
        /// <summary>
        /// Points de vie du bateau; le nombre de cases intactes restantes
        /// </summary>
        public int LifePoint { get; set; }
        /// <summary>
        /// Longueur du bateau
        /// </summary>
        public int Size { get; set; }
        /// <summary>
        /// Indique si le bateau est horizontal (true) ou vertical
        /// </summary>
        public bool Horizontal { get; set; } = true;


        /// <summary>
        /// Accepte en entrée le type du bateau (TypeBateau) ainsi que ses coordonnées de départ
        /// </summary>
        /// <param name="tb">Le type du bateau</param>
        /// <param name="cd">Ses coordonnées de départ</param>
        /// 

        public List<Point> Position { get; set; }

        public Ship(ShipType shipType, Point StartPointCoordinate, bool horizontal = true)
        {
            ID = ID_Max;
            //   ID_Max++;  l'incrimentation est déja faite dans la boucle while du ShipPlacement
            Name = shipType.ModelName;
            Size = shipType.Size;
            LifePoint = shipType.Size;
            ShipStartPointCoordinate = new Point(StartPointCoordinate.X, StartPointCoordinate.Y);
            ShipState = ShipState.ShipIntact;
            Horizontal = horizontal;
            Position = new List<Point>();
        }

    }
}
