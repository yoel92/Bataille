﻿namespace BatailleNavale
{
    /// <summary>
    /// Encapsule le type du bateau
    /// </summary>
    public class ShipType
    {
        /// <summary>
        /// Nom du type du navire (ex: sous-marin, porte-avion, etc...)
        /// </summary>
        public string ModelName { get; set; }

        public int Size { get; set; }
    }
}

