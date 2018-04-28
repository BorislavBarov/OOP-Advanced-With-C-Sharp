namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        private const string UnitNamespace = "_03BarracksFactory.Models.Units.";

        public IUnit CreateUnit(string unitType)
        {
            var uType = Type.GetType(UnitNamespace + unitType);
            var unitInstance = (IUnit)Activator.CreateInstance(uType);
            return unitInstance;
        }
    }
}
