﻿namespace TakeMeToThe
{
    public abstract class Sweet
    {
        private int price;
        private int sugarRequired;

        public int SugarRequired { get => sugarRequired; protected set => sugarRequired = value; }
    }
}