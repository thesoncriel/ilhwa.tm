using System;
using System.Collections.Generic;

namespace Theson.Util
{
    public class MultiTypeArgs : IMultiTypeArguments
    {
        private String _key = "";
        //private String _value = "";
        private int _int = 0;
        private byte[] _bytes = null;
        private Dictionary<int, int> _ints = null;
        private bool _bool = false;
        private String _string = "";
        private Dictionary<int, double> _doubles = null;
        private int _singleHexa = 0x00;

        public MultiTypeArgs(int arrayTypeSize)
            : this()
        {
            _bytes = new byte[arrayTypeSize];
        }
        public MultiTypeArgs()
        {
            _ints = new Dictionary<int, int>();
            _doubles = new Dictionary<int, double>();
        }

        public string Key
        {
            get
            {
                return _key;
            }
            set
            {
                _key = value;
            }
        }

        public int IntValue
        {
            get
            {
                return _int;
            }
            set
            {
                _int = value;
            }
        }

        public byte[] ByteValues
        {
            get
            {
                return _bytes;
            }
            set
            {
                _bytes = value;
            }
        }

        public Dictionary<int, int> IntValues
        {
            get
            {
                return _ints;
            }
            set
            {
                _ints = value;
            }
        }

        public bool BoolValue
        {
            get
            {
                return _bool;
            }
            set
            {
                _bool = value;
            }
        }

        public string StrValue
        {
            get
            {
                return _string;
            }
            set
            {
                _string = value;
            }
        }


        public Dictionary<int, double> DblValues
        {
            get
            {
                return _doubles;
            }
            set
            {
                _doubles = value;
            }
        }


        public int SingleHexa
        {
            get
            {
                return _singleHexa;
            }
            set
            {
                _singleHexa = value;
            }
        }
    }
}
