//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34209
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// #DA Schema Name:"PC"
// #DA Skipped Tables:"DSS_E1_BAS009,DSS_E1_SYS01,DSS_E1_SYS100,DSS_E1_SYS101,DSS_E1_SYS102,DSS_E1_SYS103,DSS_E1_SYS104,DSS_E1_SYS105,DSS_E1_SYS106,DSS_E1_SYS107,DSS_E1_TMP100,BJTABLE_09_VIEW,BJTABLE_09_VIEWRO,DMTABLE_08_NOPIC_VIEW,JSANDKKVIEWRO,KCTABLE_04,KKTABLE_05_VIEW,KKTABLE_05_VIEWRO,RLSBGROUP_10,RLSBGROUPSTUDENT_11,XKTABLE_VIEWRO,XYTABLE_02,XYTABLE_02RO,XKTABLE_06_VIEW,DMTABLE_08_VIEW,XSTABLE_01_VIEW,JSTABLE_03_VIEW,SKTABLE_07_VIEWRO,DMTABLE_08_BS,XSTABLE_01_BS,XKTABLE_06_BS"
namespace BriefcaseTest.PC {
    
    [RemObjects.DataAbstract.Linq.TableName("SKTABLE_07_VIEW")]
    public partial class SKTABLE_07_VIEW : System.ICloneable, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging {
        protected SKTABLE_07_VIEW m____OldValues;
        private long f____SKNO;
        private System.Nullable<long> f____KKNO;
        private string f____KKNAME;
        private System.Nullable<System.DateTime> f____SKDATE;
        private System.Nullable<long> f____LSJS;
        private System.Nullable<short> f____DMFS;
        private System.Nullable<short> f____RZFS;
        private System.Nullable<short> f____CDRS;
        private System.Nullable<short> f____ZTRS;
        private System.Nullable<short> f____KKRS;
        private System.Nullable<short> f____ZCRS;
        private System.Nullable<System.DateTime> f____EDITDATE;
        private System.Nullable<long> f____EDITMANNO;
        private System.Nullable<System.DateTime> f____XKDATE;
        private System.Nullable<System.DateTime> f____YDSKDATE;
        private System.Nullable<System.DateTime> f____YDXKDATE;
        private string f____DMPASSWORD;
        private System.Nullable<short> f____SKZT;
        [RemObjects.DataAbstract.Linq.FieldName("SKNO")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.LargeInt)]
        [RemObjects.DataAbstract.Linq.PrimaryKey()]
        [RemObjects.DataAbstract.Linq.LogChanges()]
        public virtual long SKNO {
            get {
                return f____SKNO;
            }
            set {
                if ((System.Collections.Generic.Comparer<long>.Default.Compare(this.f____SKNO, value) != 0)) {
                    this.OnPropertyChanging("SKNO");
                    f____SKNO = value;
                    this.OnPropertyChanged("SKNO");
                }
            }
        }
        [RemObjects.DataAbstract.Linq.FieldName("KKNO")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.LargeInt)]
        [RemObjects.DataAbstract.Linq.LogChanges()]
        public virtual System.Nullable<long> KKNO {
            get {
                return f____KKNO;
            }
            set {
                if ((System.Collections.Generic.Comparer<System.Nullable<long>>.Default.Compare(this.f____KKNO, value) != 0)) {
                    this.OnPropertyChanging("KKNO");
                    f____KKNO = value;
                    this.OnPropertyChanged("KKNO");
                }
            }
        }
        [RemObjects.DataAbstract.Linq.FieldName("KKNAME")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges()]
        public virtual string KKNAME {
            get {
                return f____KKNAME;
            }
            set {
                f____KKNAME = value;
            }
        }
        [RemObjects.DataAbstract.Linq.FieldName("SKDATE")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.DateTime)]
        [RemObjects.DataAbstract.Linq.LogChanges()]
        public virtual System.Nullable<System.DateTime> SKDATE {
            get {
                return f____SKDATE;
            }
            set {
                if ((System.Collections.Generic.Comparer<System.Nullable<System.DateTime>>.Default.Compare(this.f____SKDATE, value) != 0)) {
                    this.OnPropertyChanging("SKDATE");
                    f____SKDATE = value;
                    this.OnPropertyChanged("SKDATE");
                }
            }
        }
        [RemObjects.DataAbstract.Linq.FieldName("LSJS")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.LargeInt)]
        [RemObjects.DataAbstract.Linq.LogChanges()]
        public virtual System.Nullable<long> LSJS {
            get {
                return f____LSJS;
            }
            set {
                if ((System.Collections.Generic.Comparer<System.Nullable<long>>.Default.Compare(this.f____LSJS, value) != 0)) {
                    this.OnPropertyChanging("LSJS");
                    f____LSJS = value;
                    this.OnPropertyChanged("LSJS");
                }
            }
        }
        [RemObjects.DataAbstract.Linq.FieldName("DMFS")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.SmallInt)]
        [RemObjects.DataAbstract.Linq.LogChanges()]
        public virtual System.Nullable<short> DMFS {
            get {
                return f____DMFS;
            }
            set {
                if ((System.Collections.Generic.Comparer<System.Nullable<short>>.Default.Compare(this.f____DMFS, value) != 0)) {
                    this.OnPropertyChanging("DMFS");
                    f____DMFS = value;
                    this.OnPropertyChanged("DMFS");
                }
            }
        }
        [RemObjects.DataAbstract.Linq.FieldName("RZFS")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.SmallInt)]
        [RemObjects.DataAbstract.Linq.LogChanges()]
        public virtual System.Nullable<short> RZFS {
            get {
                return f____RZFS;
            }
            set {
                if ((System.Collections.Generic.Comparer<System.Nullable<short>>.Default.Compare(this.f____RZFS, value) != 0)) {
                    this.OnPropertyChanging("RZFS");
                    f____RZFS = value;
                    this.OnPropertyChanged("RZFS");
                }
            }
        }
        [RemObjects.DataAbstract.Linq.FieldName("CDRS")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.SmallInt)]
        [RemObjects.DataAbstract.Linq.LogChanges()]
        public virtual System.Nullable<short> CDRS {
            get {
                return f____CDRS;
            }
            set {
                if ((System.Collections.Generic.Comparer<System.Nullable<short>>.Default.Compare(this.f____CDRS, value) != 0)) {
                    this.OnPropertyChanging("CDRS");
                    f____CDRS = value;
                    this.OnPropertyChanged("CDRS");
                }
            }
        }
        [RemObjects.DataAbstract.Linq.FieldName("ZTRS")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.SmallInt)]
        [RemObjects.DataAbstract.Linq.LogChanges()]
        public virtual System.Nullable<short> ZTRS {
            get {
                return f____ZTRS;
            }
            set {
                if ((System.Collections.Generic.Comparer<System.Nullable<short>>.Default.Compare(this.f____ZTRS, value) != 0)) {
                    this.OnPropertyChanging("ZTRS");
                    f____ZTRS = value;
                    this.OnPropertyChanged("ZTRS");
                }
            }
        }
        [RemObjects.DataAbstract.Linq.FieldName("KKRS")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.SmallInt)]
        [RemObjects.DataAbstract.Linq.LogChanges()]
        public virtual System.Nullable<short> KKRS {
            get {
                return f____KKRS;
            }
            set {
                if ((System.Collections.Generic.Comparer<System.Nullable<short>>.Default.Compare(this.f____KKRS, value) != 0)) {
                    this.OnPropertyChanging("KKRS");
                    f____KKRS = value;
                    this.OnPropertyChanged("KKRS");
                }
            }
        }
        [RemObjects.DataAbstract.Linq.FieldName("ZCRS")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.SmallInt)]
        [RemObjects.DataAbstract.Linq.LogChanges()]
        public virtual System.Nullable<short> ZCRS {
            get {
                return f____ZCRS;
            }
            set {
                if ((System.Collections.Generic.Comparer<System.Nullable<short>>.Default.Compare(this.f____ZCRS, value) != 0)) {
                    this.OnPropertyChanging("ZCRS");
                    f____ZCRS = value;
                    this.OnPropertyChanged("ZCRS");
                }
            }
        }
        [RemObjects.DataAbstract.Linq.FieldName("EDITDATE")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.DateTime)]
        [RemObjects.DataAbstract.Linq.LogChanges()]
        public virtual System.Nullable<System.DateTime> EDITDATE {
            get {
                return f____EDITDATE;
            }
            set {
                if ((System.Collections.Generic.Comparer<System.Nullable<System.DateTime>>.Default.Compare(this.f____EDITDATE, value) != 0)) {
                    this.OnPropertyChanging("EDITDATE");
                    f____EDITDATE = value;
                    this.OnPropertyChanged("EDITDATE");
                }
            }
        }
        [RemObjects.DataAbstract.Linq.FieldName("EDITMANNO")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.LargeInt)]
        [RemObjects.DataAbstract.Linq.LogChanges()]
        public virtual System.Nullable<long> EDITMANNO {
            get {
                return f____EDITMANNO;
            }
            set {
                if ((System.Collections.Generic.Comparer<System.Nullable<long>>.Default.Compare(this.f____EDITMANNO, value) != 0)) {
                    this.OnPropertyChanging("EDITMANNO");
                    f____EDITMANNO = value;
                    this.OnPropertyChanged("EDITMANNO");
                }
            }
        }
        [RemObjects.DataAbstract.Linq.FieldName("XKDATE")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.DateTime)]
        [RemObjects.DataAbstract.Linq.LogChanges()]
        public virtual System.Nullable<System.DateTime> XKDATE {
            get {
                return f____XKDATE;
            }
            set {
                if ((System.Collections.Generic.Comparer<System.Nullable<System.DateTime>>.Default.Compare(this.f____XKDATE, value) != 0)) {
                    this.OnPropertyChanging("XKDATE");
                    f____XKDATE = value;
                    this.OnPropertyChanged("XKDATE");
                }
            }
        }
        [RemObjects.DataAbstract.Linq.FieldName("YDSKDATE")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.DateTime)]
        [RemObjects.DataAbstract.Linq.LogChanges()]
        public virtual System.Nullable<System.DateTime> YDSKDATE {
            get {
                return f____YDSKDATE;
            }
            set {
                if ((System.Collections.Generic.Comparer<System.Nullable<System.DateTime>>.Default.Compare(this.f____YDSKDATE, value) != 0)) {
                    this.OnPropertyChanging("YDSKDATE");
                    f____YDSKDATE = value;
                    this.OnPropertyChanged("YDSKDATE");
                }
            }
        }
        [RemObjects.DataAbstract.Linq.FieldName("YDXKDATE")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.DateTime)]
        [RemObjects.DataAbstract.Linq.LogChanges()]
        public virtual System.Nullable<System.DateTime> YDXKDATE {
            get {
                return f____YDXKDATE;
            }
            set {
                if ((System.Collections.Generic.Comparer<System.Nullable<System.DateTime>>.Default.Compare(this.f____YDXKDATE, value) != 0)) {
                    this.OnPropertyChanging("YDXKDATE");
                    f____YDXKDATE = value;
                    this.OnPropertyChanged("YDXKDATE");
                }
            }
        }
        [RemObjects.DataAbstract.Linq.FieldName("DMPASSWORD")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.WideString)]
        [RemObjects.DataAbstract.Linq.LogChanges()]
        public virtual string DMPASSWORD {
            get {
                return f____DMPASSWORD;
            }
            set {
                if ((System.Collections.Generic.Comparer<string>.Default.Compare(this.f____DMPASSWORD, value) != 0)) {
                    this.OnPropertyChanging("DMPASSWORD");
                    f____DMPASSWORD = value;
                    this.OnPropertyChanged("DMPASSWORD");
                }
            }
        }
        [RemObjects.DataAbstract.Linq.FieldName("SKZT")]
        [RemObjects.DataAbstract.Linq.DataType(RemObjects.DataAbstract.Schema.DataType.SmallInt)]
        [RemObjects.DataAbstract.Linq.LogChanges()]
        public virtual System.Nullable<short> SKZT {
            get {
                return f____SKZT;
            }
            set {
                if ((System.Collections.Generic.Comparer<System.Nullable<short>>.Default.Compare(this.f____SKZT, value) != 0)) {
                    this.OnPropertyChanging("SKZT");
                    f____SKZT = value;
                    this.OnPropertyChanged("SKZT");
                }
            }
        }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
        object System.ICloneable.Clone() {
            SKTABLE_07_VIEW v____new = new SKTABLE_07_VIEW();
            v____new.f____SKNO = this.f____SKNO;
            v____new.f____KKNO = this.f____KKNO;
            v____new.f____KKNAME = this.f____KKNAME;
            v____new.f____SKDATE = this.f____SKDATE;
            v____new.f____LSJS = this.f____LSJS;
            v____new.f____DMFS = this.f____DMFS;
            v____new.f____RZFS = this.f____RZFS;
            v____new.f____CDRS = this.f____CDRS;
            v____new.f____ZTRS = this.f____ZTRS;
            v____new.f____KKRS = this.f____KKRS;
            v____new.f____ZCRS = this.f____ZCRS;
            v____new.f____EDITDATE = this.f____EDITDATE;
            v____new.f____EDITMANNO = this.f____EDITMANNO;
            v____new.f____XKDATE = this.f____XKDATE;
            v____new.f____YDSKDATE = this.f____YDSKDATE;
            v____new.f____YDXKDATE = this.f____YDXKDATE;
            v____new.f____DMPASSWORD = this.f____DMPASSWORD;
            v____new.f____SKZT = this.f____SKZT;
            return v____new;
        }
        public virtual void BeginUpdate() {
            this.m____OldValues = ((SKTABLE_07_VIEW)(((System.ICloneable)(this)).Clone()));
        }
        public virtual void EndUpdate(RemObjects.DataAbstract.Linq.LinqDataAdapter dataAdapter) {
            dataAdapter.UpdateRow<SKTABLE_07_VIEW>(this.m____OldValues, this);
            this.m____OldValues = null;
        }
        public virtual void CancelUpdate() {
            this.m____OldValues = null;
        }
        protected virtual void OnPropertyChanging(string parameterName) {
            if ((this.PropertyChanging != null)) {
                this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(parameterName));
            }
        }
        protected virtual void OnPropertyChanged(string parameterName) {
            if (((this.PropertyChanged != null) 
                        && (this.m____OldValues == null))) {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(parameterName));
            }
        }
    }
    public partial class DataContext {
        private System.Collections.Generic.IEnumerable<SKTABLE_07_VIEW> f____SKTABLE_07_VIEW;
        public DataContext() {
        }
        public virtual System.Collections.Generic.IEnumerable<SKTABLE_07_VIEW> SKTABLE_07_VIEW {
            get {
                return f____SKTABLE_07_VIEW;
            }
            set {
                f____SKTABLE_07_VIEW = value;
            }
        }
    }
}
