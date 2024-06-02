namespace enum_car
{
    internal class Car
    {
        private static int _id = 0;
        public int Id { get; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Type ModelType { get; set; }
        public Car(string brand, string model, Type type)
        {
            Id = ++_id;
            Brand = brand;
            Model = model;
            ModelType = type;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Brand: {Brand}, Model: {Model}, Type: {ModelType}";
        }
    }
}
