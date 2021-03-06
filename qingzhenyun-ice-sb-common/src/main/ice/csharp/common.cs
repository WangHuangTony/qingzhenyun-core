// **********************************************************************
//
// Copyright (c) 2003-2017 ZeroC, Inc. All rights reserved.
//
// This copy of Ice is licensed to you under the terms described in the
// ICE_LICENSE file included in this distribution.
//
// **********************************************************************
//
// Ice version 3.7.0
//
// <auto-generated>
//
// Generated from file `common.ice'
//
// Warning: do not edit this file.
//
// </auto-generated>
//


using _System = global::System;

#pragma warning disable 1591

namespace IceCompactId
{
}

namespace common
{
    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1715")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1722")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724")]
    [_System.Serializable]
    public partial class CommonPage : Ice.Value
    {
        #region Slice data members

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        public int page;

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        public int pageSize;

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        public int totalCount;

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        public int totalPage;

        #endregion

        #region Constructors

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        public CommonPage()
        {
        }

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        public CommonPage(int page, int pageSize, int totalCount, int totalPage)
        {
            this.page = page;
            this.pageSize = pageSize;
            this.totalCount = totalCount;
            this.totalPage = totalPage;
        }

        #endregion

        private const string _id = "::common::CommonPage";

        public static new string ice_staticId()
        {
            return _id;
        }
        public override string ice_id()
        {
            return _id;
        }

        #region Marshaling support

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        protected override void iceWriteImpl(Ice.OutputStream ostr_)
        {
            ostr_.startSlice(ice_staticId(), -1, true);
            ostr_.writeInt(page);
            ostr_.writeInt(pageSize);
            ostr_.writeInt(totalCount);
            ostr_.writeInt(totalPage);
            ostr_.endSlice();
        }

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        protected override void iceReadImpl(Ice.InputStream istr_)
        {
            istr_.startSlice();
            page = istr_.readInt();
            pageSize = istr_.readInt();
            totalCount = istr_.readInt();
            totalPage = istr_.readInt();
            istr_.endSlice();
        }

        #endregion
    }

    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1032")]
    [_System.Serializable]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1715")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1722")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724")]
    public partial class CommonRpcException : Ice.UserException
    {
        #region Slice data members

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        public int innerCode;

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        public string innerMessage;

        #endregion

        #region Constructors

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        private void _initDM()
        {
            this.innerMessage = "";
        }

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        public CommonRpcException()
        {
            _initDM();
        }

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        public CommonRpcException(_System.Exception ex) : base(ex)
        {
            _initDM();
        }

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        public CommonRpcException(_System.Runtime.Serialization.SerializationInfo info, _System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
            this.innerCode = info.GetInt32("innerCode");
            this.innerMessage = info.GetString("innerMessage");
        }

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        private void _initDM(int innerCode, string innerMessage)
        {
            this.innerCode = innerCode;
            this.innerMessage = innerMessage;
        }

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        public CommonRpcException(int innerCode, string innerMessage)
        {
            _initDM(innerCode, innerMessage);
        }

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        public CommonRpcException(int innerCode, string innerMessage, _System.Exception ex) : base(ex)
        {
            _initDM(innerCode, innerMessage);
        }

        #endregion

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        public override string ice_id()
        {
            return "::common::CommonRpcException";
        }

        #region Object members

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        public override int GetHashCode()
        {
            int h_ = 5381;
            IceInternal.HashUtil.hashAdd(ref h_, "::common::CommonRpcException");
            IceInternal.HashUtil.hashAdd(ref h_, innerCode);
            IceInternal.HashUtil.hashAdd(ref h_, innerMessage);
            return h_;
        }

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        public override bool Equals(object other)
        {
            if(other == null)
            {
                return false;
            }
            if(object.ReferenceEquals(this, other))
            {
                return true;
            }
            CommonRpcException o = other as CommonRpcException;
            if(o == null)
            {
                return false;
            }
            if(!this.innerCode.Equals(o.innerCode))
            {
                return false;
            }
            if(this.innerMessage == null)
            {
                if(o.innerMessage != null)
                {
                    return false;
                }
            }
            else
            {
                if(!this.innerMessage.Equals(o.innerMessage))
                {
                    return false;
                }
            }
            return true;
        }

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        public override void GetObjectData(_System.Runtime.Serialization.SerializationInfo info, _System.Runtime.Serialization.StreamingContext context)
        {
            info.AddValue("innerCode", this.innerCode);
            info.AddValue("innerMessage", this.innerMessage == null ? "" : this.innerMessage);

            base.GetObjectData(info, context);
        }

        #endregion

        #region Comparison members

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        public static bool operator==(CommonRpcException lhs, CommonRpcException rhs)
        {
            return Equals(lhs, rhs);
        }

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        public static bool operator!=(CommonRpcException lhs, CommonRpcException rhs)
        {
            return !Equals(lhs, rhs);
        }

        #endregion

        #region Marshaling support

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        protected override void iceWriteImpl(Ice.OutputStream ostr_)
        {
            ostr_.startSlice("::common::CommonRpcException", -1, true);
            ostr_.writeInt(innerCode);
            ostr_.writeString(innerMessage);
            ostr_.endSlice();
        }

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
        protected override void iceReadImpl(Ice.InputStream istr_)
        {
            istr_.startSlice();
            innerCode = istr_.readInt();
            innerMessage = istr_.readString();
            istr_.endSlice();
        }

        #endregion
    }
}

namespace common
{
}

namespace common
{
}

namespace common
{
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.0")]
    public sealed class StringListHelper
    {
        public static void write(Ice.OutputStream ostr, string[] v)
        {
            ostr.writeStringSeq(v);
        }

        public static string[] read(Ice.InputStream istr)
        {
            string[] v;
            v = istr.readStringSeq();
            return v;
        }
    }
}

namespace common
{
}
