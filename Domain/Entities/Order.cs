using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using WorkerOrderManagement.Domain.Enums;

namespace WorkerOrderManagement.Domain.Entities
{
    public class Order
    {

        #region "propiedades"

        //Se usa readonly para solo lectura de la propiedad y se inicializa con el valor para no utilizar el SET.
     private readonly string _OrderId = Guid.NewGuid().ToString();   
     private EntityType _EntityType;

     private OperationType _OperationType;
     private OrderStatus _Status;
     private Aspirante _Aspirante;

        #endregion

        //GET / SET -> Encapsulación

        public string OrderId
        {
          get
            {
                return _OrderId;
            }
       
         }

    public EntityType EntityType
        {
             get{
                return _EntityType;
            }
            set
            {
                _EntityType = value;
            }
        }

         public OperationType OperationType
        {
             get{
                return _OperationType;
            }
            set
            {
                _OperationType = value;
            }
        }

    public OrderStatus Status
        {
            get
            {
                return _Status;
            }
            set
            {
                _Status = value;
            }
        }

    public Aspirante Aspirante
        {
            get
            {
                return _Aspirante;
            }
            set
            {
                _Aspirante = value;
            }
        }

       


     private void MarkAsProcessed()
        {
            this._Status = OrderStatus.PROCESSED;
        }

    public void MarkAsFail()
        {
            this._Status = OrderStatus.FAILED;
        }

    }
}