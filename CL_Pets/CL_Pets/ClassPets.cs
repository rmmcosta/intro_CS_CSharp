using System;

namespace ThirdPartyDll

{

    [Flags]
    public enum Pets
    {
        None = 0, Dog = 1, Cat = 2, Rodent = 4, Bird = 8,
        Fish = 16, Reptile = 32, Other = 64
    };



    public class ThirdPartyClass

    {

        private Pets thirdPartyPets = Pets.None;



        public ThirdPartyClass()

        {

        }



        public Pets ThirdPartyPets

        {

            get { return this.thirdPartyPets; }

            set { this.thirdPartyPets = value; }

        }



        public void DoSomeGood()

        {

            // Make some decisions based on the value

            // of thirdPartyPets

        }

    }

}