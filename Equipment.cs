using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_projekt1
{
    class Equipment
    {
        private int _equipmentID;
        private EquipmentType _equipmentType;

        public enum EquipmentType
        {
            Benchpress,
            Squatrack,
            Legcurl,
            Legextension
        }

        public Equipment(int equipmentID, EquipmentType equipmentType)
        {
            _equipmentID = equipmentID;
            _equipmentType = equipmentType;
        }
    }
}
