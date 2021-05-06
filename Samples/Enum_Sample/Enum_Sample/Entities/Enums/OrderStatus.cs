namespace Enum_Sample.Entities.Enums
{
    /* Quando for criada a classe, vai estar "class" no lugar do "enum" aqui,
    então para deixar "enum", basta só apagar o "class" e colocar "enum" no lugar. */
    /* Para especificar o tipo do seu enum, basta colocar ":"  depois do nome do seu tipo enum
     e então colocar o tipo que ele vai ser. */

    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
