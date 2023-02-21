using FluentValidator;
using MatStore.Domain.StoreContext.Enums;

namespace MatStore.Domain.StoreContext.Entities
{
    public class Delivery : Notifiable
    {
        public Delivery(DateTime estimatedDeliveryDate) {
            CreateDate = DateTime.Now;
            EstimatedDeliveryDate = estimatedDeliveryDate;
            Status = EDeliveryStatus.Waiting;
        }

        public void Ship()
        {
            if (EstimatedDeliveryDate > DateTime.Now)
            {
                Status= EDeliveryStatus.Shipped;
            }
        }

        public void Cancel()
        {
            //Se o status já estiver entregue, não cancelar
            Status = EDeliveryStatus.Canceled;
        }

        public DateTime CreateDate { get; private set; }
        public DateTime EstimatedDeliveryDate { get; private set; }
        public EDeliveryStatus Status { get; private set; }
    }
}