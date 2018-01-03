using System;
namespace PlayerLibrary
{
    public class Player
    {
        private string _name;
        private int _age;
        private double _skillLevel;
        private int _numChipsRemain; 

        public Player(string name, int age, double skillLevel, int numChipsRemain)
        {
            _name = name;
            _age = age;
            _skillLevel = skillLevel;
            _numChipsRemain = numChipsRemain;
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

        public void DecreaseChips()
        {
            _numChipsRemain--;
        }

//        class Player
//   attr_reader :name, :age, :skill_level
//   attr_accessor :num_chips_remain
//   def initialize(name, age = nil, skill_level = nil, num_chips_remain = 21)
//     @name = name
//     @age = age
//     @skill_level = skill_level
//     @num_chips_remain = num_chips_remain
//   end

//   def decrease_chips
//     @num_chips_remain -= 1
//   end
// end
    }
}
