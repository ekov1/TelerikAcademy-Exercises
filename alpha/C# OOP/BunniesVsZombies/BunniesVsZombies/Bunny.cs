using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunniesVsZombies
{
    class Bunny
    {
        private const int MINIMUM_NAME_SIZE = 3;
        private const int MAXIMUM_NAME_SIZE = 10;
        private const int MAXIMUM_HELTH = 1000;
        private const BunnyBreed DEFAULT_BREED = BunnyBreed.Mini;
        private const string DEFAULT_NAME = "jIN dOE";
        private const int DEFAULT_HEALTH = 150;

        #region Fields
        internal string id;
        private string name;
        private int health;
        // private BunnyBreed breed;
        // private List<Carrot> carrotBullets;
        #endregion

        #region Constructors
        public Bunny(string name, int health, BunnyBreed breed)
        {
            this.id = GenerateID();
            this.Name = name;
            this.Health = health;
            this.Breed = breed;
            this.CarrotBullets = new List<Carrot>();
        }



        public Bunny(string name, int health)
            : this(name, health, DEFAULT_BREED)
        { }

        public Bunny(string name)
            : this(name, DEFAULT_HEALTH, DEFAULT_BREED)
        { }

        public Bunny()
            : this(DEFAULT_NAME, DEFAULT_HEALTH, DEFAULT_BREED)
        { }
        #endregion

        #region Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < MINIMUM_NAME_SIZE || value.Length > MAXIMUM_NAME_SIZE)
                {
                    throw new ArgumentOutOfRangeException("Bunny name should be between 3 and 10 symbols!");
                }
                this.name = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if (value < 0 || value > MAXIMUM_HELTH)
                {
                    throw new ArgumentOutOfRangeException("Bunny health should be between 0 and 1000!");
                }
                this.health = value;
            }
        }

        public BunnyBreed Breed { get; private set; }

        public List<Carrot> CarrotBullets { get; private set; }

        #endregion

        #region Methods
        private string GenerateID()
        {
            throw new NotImplementedException();
        }
        #endregion

        internal class Carrot
        {
            public int damage;
            public string colour;
        }
    }

    public enum BunnyBreed
    {
        Fuzzy,
        Wuzzy,
        Mini
    }
}
