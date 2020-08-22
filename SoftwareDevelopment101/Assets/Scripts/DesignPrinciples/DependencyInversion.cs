
namespace SD101.Example.DependencyInversion
{
    using SD101.Common;
    using UnityEngine;

    public class DependencyInversion : IExample
    {
        public void Execute()
        {
            IVehicle vehicle = new Submarine();

            Commander commander = new Commander();
            //commander.Use(vehicle);

            commander.MoveToTarget();
            commander.Fire();

            //

            Player player = new Player();

            player.HealthChanged();
            player.HealthChanged();
            player.HealthChanged();
            player.HealthChanged();
            player.HealthChanged();
        }
    }

    public class Player
    {
        public delegate void SimpleAction(int healthChanged);
        public static event SimpleAction onHealthChanged;

        private int health = 100; 
        
        public void HealthChanged()
        {
            health--;
            onHealthChanged(health);
        }
    }

    public interface IVehicle
    {
        void Move();
        void Fire();
    }

    public class Submarine : IVehicle
    {
        public void Move()
        {
            Debug.Log("Submarine move!");
        }

        public void Fire()
        {
            Debug.Log("Submarine fire!");
        }
    }

    public class Tank : IVehicle
    {
        public void Move()
        {
            Debug.Log("Tank move!");
        }

        public void Fire()
        {
            Debug.Log("Tank fire!");
        }
    }

    public class Plane : IVehicle
    {
        public void Move()
        {
            Debug.Log("Plane move!");
        }

        public void Fire()
        {
            Debug.Log("Plane fire!");
        }
    }

    public class Commander
    {
        private IVehicle vehicle;

        public void Use(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public void MoveToTarget()
        {
            if (vehicle != null)
            {
                vehicle.Move();
            }
        }

        public void Fire()
        {
            if (vehicle != null)
            {
                vehicle.Fire();
            }
        }
    }
}


