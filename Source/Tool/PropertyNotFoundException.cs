using System;
using System.Runtime.Serialization;

namespace AlekseyNagovitsyn.BuildVision.Tool
{
    [Serializable]
    public class PropertyNotFoundException : Exception
    {
        private readonly string _propertyName;
        private readonly Type _type;

        public PropertyNotFoundException(string propertyName, Type type)
        {
            _propertyName = propertyName;
            _type = type;
        }

        public string PropertyName
        {
            get { return _propertyName; }
        }

        public Type Type
        {
            get { return _type; }
        }

        public override string Message
        {
            get { return string.Format("Property '{0}' not found in '{1}' type.", _propertyName, _type); }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}