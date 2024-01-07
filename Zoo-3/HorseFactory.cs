namespace Zoo_3
{
    class HorseFactory : Factory
    {
        public override Animal Create()
        {
            return new Animal(type: "Лошади", sound: "И-и-и-го-го!");
        }
    }
}