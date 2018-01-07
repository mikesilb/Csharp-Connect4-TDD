using System;
namespace PlayerLibrary
{
    public class Player
    {
        private string _name;
        private int _age;
        private double _skillLevel;
        private int _numChipsRemain; 

        public Player(string name, int age, double skillLevel, int numChipsRemain = 21)
        {
            _name = name;
            _age = age;
            _skillLevel = skillLevel;
            _numChipsRemain = numChipsRemain;
        }
        public Player(string name, int numChipsRemain = 21)
        {
            _name = name;
            _numChipsRemain = numChipsRemain;
        }
        public Player()
        {
        }


        public string GetName()
        {
            return _name;
        }

        public int GetAge()
        {
            return _age;
        }

        public double GetSkillLevel()
        {
            return _skillLevel;
        }

        public int GetNumChipsRemain()
        {
            return _numChipsRemain;
        }

        public void SetNumChipsRemain(int numChipsRemain)
        {
            _numChipsRemain = numChipsRemain;
        }

        public void DecreaseChips()
        {
            _numChipsRemain--;
        }
    }
}
