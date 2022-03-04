using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace typekey
{
    public class Interest : Typekey
    {

        public static Interest EXTREMELY_INTERESTED = new Interest("Extremely Interested");
        public static Interest INTERESTED = new Interest("Interested");
        public static Interest NOT_INTERESTED = new Interest("Not Interested");
        public static Interest NO_CHANCE = new Interest("No chance");

        /// <summary>
        /// Method to determine whether the Interest type provided is a positive one.
        /// </summary>
        /// <param name="interest">Interest object to check</param>
        /// <returns>True if Interest is 'Extremely Interested' or 'Interested'</returns>
        public static bool PositiveInterest(Interest interest)
        {
            return interest == EXTREMELY_INTERESTED || interest == INTERESTED;
        }

        /// <summary>
        /// Method to determine whether the Interest type provided is a negative one.
        /// </summary>
        /// <param name="interest">Interest object to check</param>
        /// <returns>Opposite of result from PositiveInterest bool</returns>
        public static bool NegativeInterest(Interest interest)
        {
            return !PositiveInterest(interest);
        }

        private Interest(string name) : base(name)
        {

        }

        private Interest(string name, string description) : base(name, description)
        {

        }
    }
}
