namespace Zoo_3
{
    class BearFactory : Factory
    {
        public override Animal Create()
        {
            return new Animal(type: "Медведи", sound: "Ря-я-я-яв!");
        }
    }
}