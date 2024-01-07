namespace Zoo_3
{
    class ElephantFactory : Factory
    {
        public override Animal Create()
        {
            return new Animal(type: "Слоны", sound: "Фр-р-фр!");
        }
    }
}