using Métodos_Abstratos_Sample.Entities.Enums;

namespace Métodos_Abstratos_Sample.Entities
{
    abstract class Shape //Se um método de uma classe for abstrato, toda a classe deverá ser abstrata também.
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
