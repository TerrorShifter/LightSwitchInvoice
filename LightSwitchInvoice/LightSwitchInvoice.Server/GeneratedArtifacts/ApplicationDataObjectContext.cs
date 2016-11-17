﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("LightSwitchApplication", "Order_Customer", "Customer", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(LightSwitchApplication.Implementation.Customer), "Order", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(LightSwitchApplication.Implementation.Order), true)]

#endregion

namespace LightSwitchApplication.Implementation
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ApplicationData : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ApplicationData object using the connection string found in the 'ApplicationData' section of the application configuration file.
        /// </summary>
        public ApplicationData() : base("name=ApplicationData", "ApplicationData")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ApplicationData object.
        /// </summary>
        public ApplicationData(string connectionString) : base(connectionString, "ApplicationData")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ApplicationData object.
        /// </summary>
        public ApplicationData(EntityConnection connection) : base(connection, "ApplicationData")
        {
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Customer> Customers
        {
            get
            {
                if ((_Customers == null))
                {
                    _Customers = base.CreateObjectSet<Customer>("Customers");
                }
                return _Customers;
            }
        }
        private ObjectSet<Customer> _Customers;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Order> Orders
        {
            get
            {
                if ((_Orders == null))
                {
                    _Orders = base.CreateObjectSet<Order>("Orders");
                }
                return _Orders;
            }
        }
        private ObjectSet<Order> _Orders;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Customers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCustomers(Customer customer)
        {
            base.AddObject("Customers", customer);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Orders EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrders(Order order)
        {
            base.AddObject("Orders", order);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LightSwitchApplication", Name="Customer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Customer : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Customer object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="rowVersion">Initial value of the RowVersion property.</param>
        public static Customer CreateCustomer(global::System.Int32 id, global::System.String name, global::System.Byte[] rowVersion)
        {
            Customer customer = new Customer();
            customer.Id = id;
            customer.Name = name;
            customer.RowVersion = rowVersion;
            return customer;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = value;
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = value;
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CreatedBy
        {
            get
            {
                return _CreatedBy;
            }
            set
            {
                OnCreatedByChanging(value);
                ReportPropertyChanging("CreatedBy");
                _CreatedBy = value;
                ReportPropertyChanged("CreatedBy");
                OnCreatedByChanged();
            }
        }
        private global::System.String _CreatedBy;
        partial void OnCreatedByChanging(global::System.String value);
        partial void OnCreatedByChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTimeOffset> Created
        {
            get
            {
                return _Created;
            }
            set
            {
                OnCreatedChanging(value);
                ReportPropertyChanging("Created");
                _Created = value;
                ReportPropertyChanged("Created");
                OnCreatedChanged();
            }
        }
        private Nullable<global::System.DateTimeOffset> _Created;
        partial void OnCreatedChanging(Nullable<global::System.DateTimeOffset> value);
        partial void OnCreatedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ModifiedBy
        {
            get
            {
                return _ModifiedBy;
            }
            set
            {
                OnModifiedByChanging(value);
                ReportPropertyChanging("ModifiedBy");
                _ModifiedBy = value;
                ReportPropertyChanged("ModifiedBy");
                OnModifiedByChanged();
            }
        }
        private global::System.String _ModifiedBy;
        partial void OnModifiedByChanging(global::System.String value);
        partial void OnModifiedByChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTimeOffset> Modified
        {
            get
            {
                return _Modified;
            }
            set
            {
                OnModifiedChanging(value);
                ReportPropertyChanging("Modified");
                _Modified = value;
                ReportPropertyChanged("Modified");
                OnModifiedChanged();
            }
        }
        private Nullable<global::System.DateTimeOffset> _Modified;
        partial void OnModifiedChanging(Nullable<global::System.DateTimeOffset> value);
        partial void OnModifiedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte[] RowVersion
        {
            get
            {
                return StructuralObject.GetValidValue(_RowVersion);
            }
            set
            {
                OnRowVersionChanging(value);
                ReportPropertyChanging("RowVersion");
                _RowVersion = value;
                ReportPropertyChanged("RowVersion");
                OnRowVersionChanged();
            }
        }
        private global::System.Byte[] _RowVersion;
        partial void OnRowVersionChanging(global::System.Byte[] value);
        partial void OnRowVersionChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LightSwitchApplication", "Order_Customer", "Order")]
        public EntityCollection<Order> Orders
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Order>("LightSwitchApplication.Order_Customer", "Order");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Order>("LightSwitchApplication.Order_Customer", "Order", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LightSwitchApplication", Name="Order")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Order : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Order object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="orderItem">Initial value of the OrderItem property.</param>
        /// <param name="orderAmount">Initial value of the OrderAmount property.</param>
        /// <param name="order_Customer">Initial value of the Order_Customer property.</param>
        /// <param name="rowVersion">Initial value of the RowVersion property.</param>
        public static Order CreateOrder(global::System.Int32 id, global::System.String orderItem, global::System.Decimal orderAmount, global::System.Int32 order_Customer, global::System.Byte[] rowVersion)
        {
            Order order = new Order();
            order.Id = id;
            order.OrderItem = orderItem;
            order.OrderAmount = orderAmount;
            order.Order_Customer = order_Customer;
            order.RowVersion = rowVersion;
            return order;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = value;
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String OrderItem
        {
            get
            {
                return _OrderItem;
            }
            set
            {
                OnOrderItemChanging(value);
                ReportPropertyChanging("OrderItem");
                _OrderItem = value;
                ReportPropertyChanged("OrderItem");
                OnOrderItemChanged();
            }
        }
        private global::System.String _OrderItem;
        partial void OnOrderItemChanging(global::System.String value);
        partial void OnOrderItemChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal OrderAmount
        {
            get
            {
                return _OrderAmount;
            }
            set
            {
                OnOrderAmountChanging(value);
                ReportPropertyChanging("OrderAmount");
                _OrderAmount = value;
                ReportPropertyChanged("OrderAmount");
                OnOrderAmountChanged();
            }
        }
        private global::System.Decimal _OrderAmount;
        partial void OnOrderAmountChanging(global::System.Decimal value);
        partial void OnOrderAmountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Order_Customer
        {
            get
            {
                return _Order_Customer;
            }
            set
            {
                OnOrder_CustomerChanging(value);
                ReportPropertyChanging("Order_Customer");
                _Order_Customer = value;
                ReportPropertyChanged("Order_Customer");
                OnOrder_CustomerChanged();
            }
        }
        private global::System.Int32 _Order_Customer;
        partial void OnOrder_CustomerChanging(global::System.Int32 value);
        partial void OnOrder_CustomerChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CreatedBy
        {
            get
            {
                return _CreatedBy;
            }
            set
            {
                OnCreatedByChanging(value);
                ReportPropertyChanging("CreatedBy");
                _CreatedBy = value;
                ReportPropertyChanged("CreatedBy");
                OnCreatedByChanged();
            }
        }
        private global::System.String _CreatedBy;
        partial void OnCreatedByChanging(global::System.String value);
        partial void OnCreatedByChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTimeOffset> Created
        {
            get
            {
                return _Created;
            }
            set
            {
                OnCreatedChanging(value);
                ReportPropertyChanging("Created");
                _Created = value;
                ReportPropertyChanged("Created");
                OnCreatedChanged();
            }
        }
        private Nullable<global::System.DateTimeOffset> _Created;
        partial void OnCreatedChanging(Nullable<global::System.DateTimeOffset> value);
        partial void OnCreatedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ModifiedBy
        {
            get
            {
                return _ModifiedBy;
            }
            set
            {
                OnModifiedByChanging(value);
                ReportPropertyChanging("ModifiedBy");
                _ModifiedBy = value;
                ReportPropertyChanged("ModifiedBy");
                OnModifiedByChanged();
            }
        }
        private global::System.String _ModifiedBy;
        partial void OnModifiedByChanging(global::System.String value);
        partial void OnModifiedByChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTimeOffset> Modified
        {
            get
            {
                return _Modified;
            }
            set
            {
                OnModifiedChanging(value);
                ReportPropertyChanging("Modified");
                _Modified = value;
                ReportPropertyChanged("Modified");
                OnModifiedChanged();
            }
        }
        private Nullable<global::System.DateTimeOffset> _Modified;
        partial void OnModifiedChanging(Nullable<global::System.DateTimeOffset> value);
        partial void OnModifiedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte[] RowVersion
        {
            get
            {
                return StructuralObject.GetValidValue(_RowVersion);
            }
            set
            {
                OnRowVersionChanging(value);
                ReportPropertyChanging("RowVersion");
                _RowVersion = value;
                ReportPropertyChanged("RowVersion");
                OnRowVersionChanged();
            }
        }
        private global::System.Byte[] _RowVersion;
        partial void OnRowVersionChanging(global::System.Byte[] value);
        partial void OnRowVersionChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LightSwitchApplication", "Order_Customer", "Customer")]
        public Customer Customer
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("LightSwitchApplication.Order_Customer", "Customer").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("LightSwitchApplication.Order_Customer", "Customer").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Customer> CustomerReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("LightSwitchApplication.Order_Customer", "Customer");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Customer>("LightSwitchApplication.Order_Customer", "Customer", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
