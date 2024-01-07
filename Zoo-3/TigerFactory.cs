namespace Zoo_3
{
    class TigerFactory : Factory
    {
        public override Animal Create()
        {
            return new Animal(type: "Тигры", sound: "Р-р-р!");
        }
    }
}