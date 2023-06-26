using UnityEngine;

namespace Assets.Scripts.Common
{
    public abstract class Unit : MonoBehaviour
    {
        public virtual void Remove(bool withGameObject = false)
        {
            if (this == null) return;

            Destroy(this);
            if (withGameObject)
            {
                Destroy(gameObject);
            }
        }
    }
}