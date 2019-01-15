#pragma warning disable 1591

namespace SkladSUBD
{


    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("SkladDataSet")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class SkladDataSet : global::System.Data.DataSet
    {

        private KlientiDataTable tableKlienti;

        private PostavshikiDataTable tablePostavshiki;

        private PrihodDataTable tablePrihod;

        private RashodDataTable tableRashod;

        private SotrudnikiDataTable tableSotrudniki;

        private TovariDataTable tableTovari;

        private global::System.Data.DataRelation relationPostavshikiPrihod;

        private global::System.Data.DataRelation relationSotrudnikPrihod;

        private global::System.Data.DataRelation relationTovariPrihod;

        private global::System.Data.DataRelation relationKlientiRashod;

        private global::System.Data.DataRelation relationSotrudnikiRashod;

        private global::System.Data.DataRelation relationTovariRashod;

        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public SkladDataSet()
        {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
            this.InitExpressions();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected SkladDataSet(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base(info, context, false)
        {
            if ((this.IsBinarySerialized(info, context) == true))
            {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.ExcludeSchema))
                {
                    this.InitExpressions();
                }
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema))
            {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                if ((ds.Tables["Klienti"] != null))
                {
                    base.Tables.Add(new KlientiDataTable(ds.Tables["Klienti"]));
                }
                if ((ds.Tables["Postavshiki"] != null))
                {
                    base.Tables.Add(new PostavshikiDataTable(ds.Tables["Postavshiki"]));
                }
                if ((ds.Tables["Prihod"] != null))
                {
                    base.Tables.Add(new PrihodDataTable(ds.Tables["Prihod"]));
                }
                if ((ds.Tables["Rashod"] != null))
                {
                    base.Tables.Add(new RashodDataTable(ds.Tables["Rashod"]));
                }
                if ((ds.Tables["Sotrudniki"] != null))
                {
                    base.Tables.Add(new SotrudnikiDataTable(ds.Tables["Sotrudniki"]));
                }
                if ((ds.Tables["Tovari"] != null))
                {
                    base.Tables.Add(new TovariDataTable(ds.Tables["Tovari"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else
            {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                this.InitExpressions();
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public KlientiDataTable Klienti
        {
            get
            {
                return this.tableKlienti;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public PostavshikiDataTable Postavshiki
        {
            get
            {
                return this.tablePostavshiki;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public PrihodDataTable Prihod
        {
            get
            {
                return this.tablePrihod;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public RashodDataTable Rashod
        {
            get
            {
                return this.tableRashod;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public SotrudnikiDataTable Sotrudniki
        {
            get
            {
                return this.tableSotrudniki;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public TovariDataTable Tovari
        {
            get
            {
                return this.tableTovari;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode
        {
            get
            {
                return this._schemaSerializationMode;
            }
            set
            {
                this._schemaSerializationMode = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables
        {
            get
            {
                return base.Tables;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations
        {
            get
            {
                return base.Relations;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void InitializeDerivedDataSet()
        {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override global::System.Data.DataSet Clone()
        {
            SkladDataSet cln = ((SkladDataSet)(base.Clone()));
            cln.InitVars();
            cln.InitExpressions();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeTables()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeRelations()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader)
        {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema))
            {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["Klienti"] != null))
                {
                    base.Tables.Add(new KlientiDataTable(ds.Tables["Klienti"]));
                }
                if ((ds.Tables["Postavshiki"] != null))
                {
                    base.Tables.Add(new PostavshikiDataTable(ds.Tables["Postavshiki"]));
                }
                if ((ds.Tables["Prihod"] != null))
                {
                    base.Tables.Add(new PrihodDataTable(ds.Tables["Prihod"]));
                }
                if ((ds.Tables["Rashod"] != null))
                {
                    base.Tables.Add(new RashodDataTable(ds.Tables["Rashod"]));
                }
                if ((ds.Tables["Sotrudniki"] != null))
                {
                    base.Tables.Add(new SotrudnikiDataTable(ds.Tables["Sotrudniki"]));
                }
                if ((ds.Tables["Tovari"] != null))
                {
                    base.Tables.Add(new TovariDataTable(ds.Tables["Tovari"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else
            {
                this.ReadXml(reader);
                this.InitVars();
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable()
        {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars()
        {
            this.InitVars(true);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars(bool initTable)
        {
            this.tableKlienti = ((KlientiDataTable)(base.Tables["Klienti"]));
            if ((initTable == true))
            {
                if ((this.tableKlienti != null))
                {
                    this.tableKlienti.InitVars();
                }
            }
            this.tablePostavshiki = ((PostavshikiDataTable)(base.Tables["Postavshiki"]));
            if ((initTable == true))
            {
                if ((this.tablePostavshiki != null))
                {
                    this.tablePostavshiki.InitVars();
                }
            }
            this.tablePrihod = ((PrihodDataTable)(base.Tables["Prihod"]));
            if ((initTable == true))
            {
                if ((this.tablePrihod != null))
                {
                    this.tablePrihod.InitVars();
                }
            }
            this.tableRashod = ((RashodDataTable)(base.Tables["Rashod"]));
            if ((initTable == true))
            {
                if ((this.tableRashod != null))
                {
                    this.tableRashod.InitVars();
                }
            }
            this.tableSotrudniki = ((SotrudnikiDataTable)(base.Tables["Sotrudniki"]));
            if ((initTable == true))
            {
                if ((this.tableSotrudniki != null))
                {
                    this.tableSotrudniki.InitVars();
                }
            }
            this.tableTovari = ((TovariDataTable)(base.Tables["Tovari"]));
            if ((initTable == true))
            {
                if ((this.tableTovari != null))
                {
                    this.tableTovari.InitVars();
                }
            }
            this.relationPostavshikiPrihod = this.Relations["PostavshikiPrihod"];
            this.relationSotrudnikPrihod = this.Relations["SotrudnikPrihod"];
            this.relationTovariPrihod = this.Relations["TovariPrihod"];
            this.relationKlientiRashod = this.Relations["KlientiRashod"];
            this.relationSotrudnikiRashod = this.Relations["SotrudnikiRashod"];
            this.relationTovariRashod = this.Relations["TovariRashod"];
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass()
        {
            this.DataSetName = "SkladDataSet";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/SkladDataSet.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
            this.tableKlienti = new KlientiDataTable();
            base.Tables.Add(this.tableKlienti);
            this.tablePostavshiki = new PostavshikiDataTable();
            base.Tables.Add(this.tablePostavshiki);
            this.tablePrihod = new PrihodDataTable();
            base.Tables.Add(this.tablePrihod);
            this.tableRashod = new RashodDataTable();
            base.Tables.Add(this.tableRashod);
            this.tableSotrudniki = new SotrudnikiDataTable(false);
            base.Tables.Add(this.tableSotrudniki);
            this.tableTovari = new TovariDataTable();
            base.Tables.Add(this.tableTovari);
            this.relationPostavshikiPrihod = new global::System.Data.DataRelation("PostavshikiPrihod", new global::System.Data.DataColumn[] {
                        this.tablePostavshiki.idpostavshikColumn}, new global::System.Data.DataColumn[] {
                        this.tablePrihod.idpostavshikColumn}, false);
            this.Relations.Add(this.relationPostavshikiPrihod);
            this.relationSotrudnikPrihod = new global::System.Data.DataRelation("SotrudnikPrihod", new global::System.Data.DataColumn[] {
                        this.tableSotrudniki.idsotrudnikaColumn}, new global::System.Data.DataColumn[] {
                        this.tablePrihod.idsotrudnikaColumn}, false);
            this.Relations.Add(this.relationSotrudnikPrihod);
            this.relationTovariPrihod = new global::System.Data.DataRelation("TovariPrihod", new global::System.Data.DataColumn[] {
                        this.tableTovari.idtovaraColumn}, new global::System.Data.DataColumn[] {
                        this.tablePrihod.idtovaraColumn}, false);
            this.Relations.Add(this.relationTovariPrihod);
            this.relationKlientiRashod = new global::System.Data.DataRelation("KlientiRashod", new global::System.Data.DataColumn[] {
                        this.tableKlienti.idklientaColumn}, new global::System.Data.DataColumn[] {
                        this.tableRashod.idklientaColumn}, false);
            this.Relations.Add(this.relationKlientiRashod);
            this.relationSotrudnikiRashod = new global::System.Data.DataRelation("SotrudnikiRashod", new global::System.Data.DataColumn[] {
                        this.tableSotrudniki.idsotrudnikaColumn}, new global::System.Data.DataColumn[] {
                        this.tableRashod.idsotrudnikaColumn}, false);
            this.Relations.Add(this.relationSotrudnikiRashod);
            this.relationTovariRashod = new global::System.Data.DataRelation("TovariRashod", new global::System.Data.DataColumn[] {
                        this.tableTovari.idtovaraColumn}, new global::System.Data.DataColumn[] {
                        this.tableRashod.idtovaraColumn}, false);
            this.Relations.Add(this.relationTovariRashod);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeKlienti()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializePostavshiki()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializePrihod()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeRashod()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeSotrudniki()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeTovari()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e)
        {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove))
            {
                this.InitVars();
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs)
        {
            SkladDataSet ds = new SkladDataSet();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace))
            {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try
                {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); )
                    {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length))
                        {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length)
                                        && (s1.ReadByte() == s2.ReadByte())); )
                            {
                                ;
                            }
                            if ((s1.Position == s1.Length))
                            {
                                return type;
                            }
                        }
                    }
                }
                finally
                {
                    if ((s1 != null))
                    {
                        s1.Close();
                    }
                    if ((s2 != null))
                    {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitExpressions()
        {
            this.Sotrudniki.fioColumn.Expression = "fam + \' \'+substring(name, 1,1) + \'.\'+substring(otch,1,1) + \'.\'";
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void KlientiRowChangeEventHandler(object sender, KlientiRowChangeEvent e);

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void PostavshikiRowChangeEventHandler(object sender, PostavshikiRowChangeEvent e);

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void PrihodRowChangeEventHandler(object sender, PrihodRowChangeEvent e);

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void RashodRowChangeEventHandler(object sender, RashodRowChangeEvent e);

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void SotrudnikiRowChangeEventHandler(object sender, SotrudnikiRowChangeEvent e);

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void TovariRowChangeEventHandler(object sender, TovariRowChangeEvent e);

        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class KlientiDataTable : global::System.Data.TypedTableBase<KlientiRow>
        {

            private global::System.Data.DataColumn columnidklienta;

            private global::System.Data.DataColumn columnnameklienta;

            private global::System.Data.DataColumn columngorod;

            private global::System.Data.DataColumn columnulica;

            private global::System.Data.DataColumn columndom;

            private global::System.Data.DataColumn columntelefon;

            private global::System.Data.DataColumn columnprimechanie;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public KlientiDataTable()
            {
                this.TableName = "Klienti";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal KlientiDataTable(global::System.Data.DataTable table)
            {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive))
                {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString()))
                {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace))
                {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected KlientiDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base(info, context)
            {
                this.InitVars();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn idklientaColumn
            {
                get
                {
                    return this.columnidklienta;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn nameklientaColumn
            {
                get
                {
                    return this.columnnameklienta;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn gorodColumn
            {
                get
                {
                    return this.columngorod;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ulicaColumn
            {
                get
                {
                    return this.columnulica;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn domColumn
            {
                get
                {
                    return this.columndom;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn telefonColumn
            {
                get
                {
                    return this.columntelefon;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn primechanieColumn
            {
                get
                {
                    return this.columnprimechanie;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count
            {
                get
                {
                    return this.Rows.Count;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public KlientiRow this[int index]
            {
                get
                {
                    return ((KlientiRow)(this.Rows[index]));
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event KlientiRowChangeEventHandler KlientiRowChanging;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event KlientiRowChangeEventHandler KlientiRowChanged;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event KlientiRowChangeEventHandler KlientiRowDeleting;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event KlientiRowChangeEventHandler KlientiRowDeleted;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddKlientiRow(KlientiRow row)
            {
                this.Rows.Add(row);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public KlientiRow AddKlientiRow(string nameklienta, string gorod, string ulica, string dom, string telefon, string primechanie)
            {
                KlientiRow rowKlientiRow = ((KlientiRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        nameklienta,
                        gorod,
                        ulica,
                        dom,
                        telefon,
                        primechanie};
                rowKlientiRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowKlientiRow);
                return rowKlientiRow;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public KlientiRow FindByidklienta(int idklienta)
            {
                return ((KlientiRow)(this.Rows.Find(new object[] {
                            idklienta})));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone()
            {
                KlientiDataTable cln = ((KlientiDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance()
            {
                return new KlientiDataTable();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars()
            {
                this.columnidklienta = base.Columns["idklienta"];
                this.columnnameklienta = base.Columns["nameklienta"];
                this.columngorod = base.Columns["gorod"];
                this.columnulica = base.Columns["ulica"];
                this.columndom = base.Columns["dom"];
                this.columntelefon = base.Columns["telefon"];
                this.columnprimechanie = base.Columns["primechanie"];
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columnidklienta = new global::System.Data.DataColumn("idklienta", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnidklienta);
                this.columnnameklienta = new global::System.Data.DataColumn("nameklienta", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnnameklienta);
                this.columngorod = new global::System.Data.DataColumn("gorod", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columngorod);
                this.columnulica = new global::System.Data.DataColumn("ulica", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnulica);
                this.columndom = new global::System.Data.DataColumn("dom", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columndom);
                this.columntelefon = new global::System.Data.DataColumn("telefon", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columntelefon);
                this.columnprimechanie = new global::System.Data.DataColumn("primechanie", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnprimechanie);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnidklienta}, true));
                this.columnidklienta.AutoIncrement = true;
                this.columnidklienta.AutoIncrementSeed = 1;
                this.columnidklienta.AllowDBNull = false;
                this.columnidklienta.ReadOnly = true;
                this.columnidklienta.Unique = true;
                this.columnnameklienta.MaxLength = 50;
                this.columngorod.MaxLength = 50;
                this.columnulica.MaxLength = 50;
                this.columndom.MaxLength = 5;
                this.columntelefon.MaxLength = 15;
                this.columnprimechanie.MaxLength = 100;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public KlientiRow NewKlientiRow()
            {
                return ((KlientiRow)(this.NewRow()));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder)
            {
                return new KlientiRow(builder);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType()
            {
                return typeof(KlientiRow);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if ((this.KlientiRowChanged != null))
                {
                    this.KlientiRowChanged(this, new KlientiRowChangeEvent(((KlientiRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if ((this.KlientiRowChanging != null))
                {
                    this.KlientiRowChanging(this, new KlientiRowChangeEvent(((KlientiRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if ((this.KlientiRowDeleted != null))
                {
                    this.KlientiRowDeleted(this, new KlientiRowChangeEvent(((KlientiRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if ((this.KlientiRowDeleting != null))
                {
                    this.KlientiRowDeleting(this, new KlientiRowChangeEvent(((KlientiRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveKlientiRow(KlientiRow row)
            {
                this.Rows.Remove(row);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs)
            {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                SkladDataSet ds = new SkladDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "KlientiDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace))
                {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try
                    {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); )
                        {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length))
                            {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length)
                                            && (s1.ReadByte() == s2.ReadByte())); )
                                {
                                    ;
                                }
                                if ((s1.Position == s1.Length))
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if ((s1 != null))
                        {
                            s1.Close();
                        }
                        if ((s2 != null))
                        {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }

        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class PostavshikiDataTable : global::System.Data.TypedTableBase<PostavshikiRow>
        {

            private global::System.Data.DataColumn columnidpostavshik;

            private global::System.Data.DataColumn columnnamepostavshik;

            private global::System.Data.DataColumn columngorod;

            private global::System.Data.DataColumn columnulica;

            private global::System.Data.DataColumn columndom;

            private global::System.Data.DataColumn columntelefon;

            private global::System.Data.DataColumn columnprimechanie;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PostavshikiDataTable()
            {
                this.TableName = "Postavshiki";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal PostavshikiDataTable(global::System.Data.DataTable table)
            {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive))
                {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString()))
                {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace))
                {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected PostavshikiDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base(info, context)
            {
                this.InitVars();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn idpostavshikColumn
            {
                get
                {
                    return this.columnidpostavshik;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn namepostavshikColumn
            {
                get
                {
                    return this.columnnamepostavshik;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn gorodColumn
            {
                get
                {
                    return this.columngorod;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ulicaColumn
            {
                get
                {
                    return this.columnulica;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn domColumn
            {
                get
                {
                    return this.columndom;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn telefonColumn
            {
                get
                {
                    return this.columntelefon;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn primechanieColumn
            {
                get
                {
                    return this.columnprimechanie;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count
            {
                get
                {
                    return this.Rows.Count;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PostavshikiRow this[int index]
            {
                get
                {
                    return ((PostavshikiRow)(this.Rows[index]));
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PostavshikiRowChangeEventHandler PostavshikiRowChanging;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PostavshikiRowChangeEventHandler PostavshikiRowChanged;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PostavshikiRowChangeEventHandler PostavshikiRowDeleting;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PostavshikiRowChangeEventHandler PostavshikiRowDeleted;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddPostavshikiRow(PostavshikiRow row)
            {
                this.Rows.Add(row);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PostavshikiRow AddPostavshikiRow(string namepostavshik, string gorod, string ulica, string dom, string telefon, string primechanie)
            {
                PostavshikiRow rowPostavshikiRow = ((PostavshikiRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        namepostavshik,
                        gorod,
                        ulica,
                        dom,
                        telefon,
                        primechanie};
                rowPostavshikiRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowPostavshikiRow);
                return rowPostavshikiRow;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PostavshikiRow FindByidpostavshik(int idpostavshik)
            {
                return ((PostavshikiRow)(this.Rows.Find(new object[] {
                            idpostavshik})));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone()
            {
                PostavshikiDataTable cln = ((PostavshikiDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance()
            {
                return new PostavshikiDataTable();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars()
            {
                this.columnidpostavshik = base.Columns["idpostavshik"];
                this.columnnamepostavshik = base.Columns["namepostavshik"];
                this.columngorod = base.Columns["gorod"];
                this.columnulica = base.Columns["ulica"];
                this.columndom = base.Columns["dom"];
                this.columntelefon = base.Columns["telefon"];
                this.columnprimechanie = base.Columns["primechanie"];
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columnidpostavshik = new global::System.Data.DataColumn("idpostavshik", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnidpostavshik);
                this.columnnamepostavshik = new global::System.Data.DataColumn("namepostavshik", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnnamepostavshik);
                this.columngorod = new global::System.Data.DataColumn("gorod", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columngorod);
                this.columnulica = new global::System.Data.DataColumn("ulica", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnulica);
                this.columndom = new global::System.Data.DataColumn("dom", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columndom);
                this.columntelefon = new global::System.Data.DataColumn("telefon", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columntelefon);
                this.columnprimechanie = new global::System.Data.DataColumn("primechanie", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnprimechanie);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnidpostavshik}, true));
                this.columnidpostavshik.AutoIncrement = true;
                this.columnidpostavshik.AutoIncrementSeed = 1;
                this.columnidpostavshik.AllowDBNull = false;
                this.columnidpostavshik.ReadOnly = true;
                this.columnidpostavshik.Unique = true;
                this.columnnamepostavshik.MaxLength = 50;
                this.columngorod.MaxLength = 50;
                this.columnulica.MaxLength = 50;
                this.columndom.MaxLength = 5;
                this.columntelefon.MaxLength = 15;
                this.columnprimechanie.MaxLength = 100;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PostavshikiRow NewPostavshikiRow()
            {
                return ((PostavshikiRow)(this.NewRow()));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder)
            {
                return new PostavshikiRow(builder);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType()
            {
                return typeof(PostavshikiRow);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if ((this.PostavshikiRowChanged != null))
                {
                    this.PostavshikiRowChanged(this, new PostavshikiRowChangeEvent(((PostavshikiRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if ((this.PostavshikiRowChanging != null))
                {
                    this.PostavshikiRowChanging(this, new PostavshikiRowChangeEvent(((PostavshikiRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if ((this.PostavshikiRowDeleted != null))
                {
                    this.PostavshikiRowDeleted(this, new PostavshikiRowChangeEvent(((PostavshikiRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if ((this.PostavshikiRowDeleting != null))
                {
                    this.PostavshikiRowDeleting(this, new PostavshikiRowChangeEvent(((PostavshikiRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemovePostavshikiRow(PostavshikiRow row)
            {
                this.Rows.Remove(row);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs)
            {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                SkladDataSet ds = new SkladDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "PostavshikiDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace))
                {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try
                    {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); )
                        {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length))
                            {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length)
                                            && (s1.ReadByte() == s2.ReadByte())); )
                                {
                                    ;
                                }
                                if ((s1.Position == s1.Length))
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if ((s1 != null))
                        {
                            s1.Close();
                        }
                        if ((s2 != null))
                        {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }

        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class PrihodDataTable : global::System.Data.TypedTableBase<PrihodRow>
        {

            private global::System.Data.DataColumn columnidprihod;

            private global::System.Data.DataColumn columnidpostavshik;

            private global::System.Data.DataColumn columnidtovara;

            private global::System.Data.DataColumn columnidsotrudnika;

            private global::System.Data.DataColumn columnnakladnaya;

            private global::System.Data.DataColumn columnkolichestvo;

            private global::System.Data.DataColumn columndatapolucheniya;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PrihodDataTable()
            {
                this.TableName = "Prihod";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal PrihodDataTable(global::System.Data.DataTable table)
            {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive))
                {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString()))
                {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace))
                {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected PrihodDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base(info, context)
            {
                this.InitVars();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn idprihodColumn
            {
                get
                {
                    return this.columnidprihod;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn idpostavshikColumn
            {
                get
                {
                    return this.columnidpostavshik;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn idtovaraColumn
            {
                get
                {
                    return this.columnidtovara;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn idsotrudnikaColumn
            {
                get
                {
                    return this.columnidsotrudnika;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn nakladnayaColumn
            {
                get
                {
                    return this.columnnakladnaya;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn kolichestvoColumn
            {
                get
                {
                    return this.columnkolichestvo;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn datapolucheniyaColumn
            {
                get
                {
                    return this.columndatapolucheniya;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count
            {
                get
                {
                    return this.Rows.Count;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PrihodRow this[int index]
            {
                get
                {
                    return ((PrihodRow)(this.Rows[index]));
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PrihodRowChangeEventHandler PrihodRowChanging;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PrihodRowChangeEventHandler PrihodRowChanged;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PrihodRowChangeEventHandler PrihodRowDeleting;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event PrihodRowChangeEventHandler PrihodRowDeleted;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddPrihodRow(PrihodRow row)
            {
                this.Rows.Add(row);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PrihodRow AddPrihodRow(PostavshikiRow parentPostavshikiRowByPostavshikiPrihod, TovariRow parentTovariRowByTovariPrihod, SotrudnikiRow parentSotrudnikiRowBySotrudnikPrihod, string nakladnaya, int kolichestvo, System.DateTime datapolucheniya)
            {
                PrihodRow rowPrihodRow = ((PrihodRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        null,
                        null,
                        null,
                        nakladnaya,
                        kolichestvo,
                        datapolucheniya};
                if ((parentPostavshikiRowByPostavshikiPrihod != null))
                {
                    columnValuesArray[1] = parentPostavshikiRowByPostavshikiPrihod[0];
                }
                if ((parentTovariRowByTovariPrihod != null))
                {
                    columnValuesArray[2] = parentTovariRowByTovariPrihod[0];
                }
                if ((parentSotrudnikiRowBySotrudnikPrihod != null))
                {
                    columnValuesArray[3] = parentSotrudnikiRowBySotrudnikPrihod[0];
                }
                rowPrihodRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowPrihodRow);
                return rowPrihodRow;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PrihodRow FindByidprihod(int idprihod)
            {
                return ((PrihodRow)(this.Rows.Find(new object[] {
                            idprihod})));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone()
            {
                PrihodDataTable cln = ((PrihodDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance()
            {
                return new PrihodDataTable();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars()
            {
                this.columnidprihod = base.Columns["idprihod"];
                this.columnidpostavshik = base.Columns["idpostavshik"];
                this.columnidtovara = base.Columns["idtovara"];
                this.columnidsotrudnika = base.Columns["idsotrudnika"];
                this.columnnakladnaya = base.Columns["nakladnaya"];
                this.columnkolichestvo = base.Columns["kolichestvo"];
                this.columndatapolucheniya = base.Columns["datapolucheniya"];
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columnidprihod = new global::System.Data.DataColumn("idprihod", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnidprihod);
                this.columnidpostavshik = new global::System.Data.DataColumn("idpostavshik", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnidpostavshik);
                this.columnidtovara = new global::System.Data.DataColumn("idtovara", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnidtovara);
                this.columnidsotrudnika = new global::System.Data.DataColumn("idsotrudnika", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnidsotrudnika);
                this.columnnakladnaya = new global::System.Data.DataColumn("nakladnaya", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnnakladnaya);
                this.columnkolichestvo = new global::System.Data.DataColumn("kolichestvo", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnkolichestvo);
                this.columndatapolucheniya = new global::System.Data.DataColumn("datapolucheniya", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columndatapolucheniya);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnidprihod}, true));
                this.columnidprihod.AutoIncrement = true;
                this.columnidprihod.AutoIncrementSeed = 1;
                this.columnidprihod.AllowDBNull = false;
                this.columnidprihod.ReadOnly = true;
                this.columnidprihod.Unique = true;
                this.columnidpostavshik.AllowDBNull = false;
                this.columnidtovara.AllowDBNull = false;
                this.columnidsotrudnika.AllowDBNull = false;
                this.columnnakladnaya.AutoIncrementSeed = 1;
                this.columnnakladnaya.MaxLength = 10;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PrihodRow NewPrihodRow()
            {
                return ((PrihodRow)(this.NewRow()));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder)
            {
                return new PrihodRow(builder);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType()
            {
                return typeof(PrihodRow);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if ((this.PrihodRowChanged != null))
                {
                    this.PrihodRowChanged(this, new PrihodRowChangeEvent(((PrihodRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if ((this.PrihodRowChanging != null))
                {
                    this.PrihodRowChanging(this, new PrihodRowChangeEvent(((PrihodRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if ((this.PrihodRowDeleted != null))
                {
                    this.PrihodRowDeleted(this, new PrihodRowChangeEvent(((PrihodRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if ((this.PrihodRowDeleting != null))
                {
                    this.PrihodRowDeleting(this, new PrihodRowChangeEvent(((PrihodRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemovePrihodRow(PrihodRow row)
            {
                this.Rows.Remove(row);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs)
            {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                SkladDataSet ds = new SkladDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "PrihodDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace))
                {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try
                    {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); )
                        {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length))
                            {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length)
                                            && (s1.ReadByte() == s2.ReadByte())); )
                                {
                                    ;
                                }
                                if ((s1.Position == s1.Length))
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if ((s1 != null))
                        {
                            s1.Close();
                        }
                        if ((s2 != null))
                        {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }

        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class RashodDataTable : global::System.Data.TypedTableBase<RashodRow>
        {

            private global::System.Data.DataColumn columnidrashod;

            private global::System.Data.DataColumn columnidklienta;

            private global::System.Data.DataColumn columnidtovara;

            private global::System.Data.DataColumn columnidsotrudnika;

            private global::System.Data.DataColumn columnnakladnaya;

            private global::System.Data.DataColumn columnkolichestvo;

            private global::System.Data.DataColumn columndatavidachi;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public RashodDataTable()
            {
                this.TableName = "Rashod";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal RashodDataTable(global::System.Data.DataTable table)
            {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive))
                {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString()))
                {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace))
                {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected RashodDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base(info, context)
            {
                this.InitVars();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn idrashodColumn
            {
                get
                {
                    return this.columnidrashod;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn idklientaColumn
            {
                get
                {
                    return this.columnidklienta;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn idtovaraColumn
            {
                get
                {
                    return this.columnidtovara;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn idsotrudnikaColumn
            {
                get
                {
                    return this.columnidsotrudnika;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn nakladnayaColumn
            {
                get
                {
                    return this.columnnakladnaya;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn kolichestvoColumn
            {
                get
                {
                    return this.columnkolichestvo;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn datavidachiColumn
            {
                get
                {
                    return this.columndatavidachi;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count
            {
                get
                {
                    return this.Rows.Count;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public RashodRow this[int index]
            {
                get
                {
                    return ((RashodRow)(this.Rows[index]));
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event RashodRowChangeEventHandler RashodRowChanging;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event RashodRowChangeEventHandler RashodRowChanged;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event RashodRowChangeEventHandler RashodRowDeleting;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event RashodRowChangeEventHandler RashodRowDeleted;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddRashodRow(RashodRow row)
            {
                this.Rows.Add(row);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public RashodRow AddRashodRow(KlientiRow parentKlientiRowByKlientiRashod, TovariRow parentTovariRowByTovariRashod, SotrudnikiRow parentSotrudnikiRowBySotrudnikiRashod, string nakladnaya, int kolichestvo, System.DateTime datavidachi)
            {
                RashodRow rowRashodRow = ((RashodRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        null,
                        null,
                        null,
                        nakladnaya,
                        kolichestvo,
                        datavidachi};
                if ((parentKlientiRowByKlientiRashod != null))
                {
                    columnValuesArray[1] = parentKlientiRowByKlientiRashod[0];
                }
                if ((parentTovariRowByTovariRashod != null))
                {
                    columnValuesArray[2] = parentTovariRowByTovariRashod[0];
                }
                if ((parentSotrudnikiRowBySotrudnikiRashod != null))
                {
                    columnValuesArray[3] = parentSotrudnikiRowBySotrudnikiRashod[0];
                }
                rowRashodRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowRashodRow);
                return rowRashodRow;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public RashodRow FindByidrashod(int idrashod)
            {
                return ((RashodRow)(this.Rows.Find(new object[] {
                            idrashod})));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone()
            {
                RashodDataTable cln = ((RashodDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance()
            {
                return new RashodDataTable();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars()
            {
                this.columnidrashod = base.Columns["idrashod"];
                this.columnidklienta = base.Columns["idklienta"];
                this.columnidtovara = base.Columns["idtovara"];
                this.columnidsotrudnika = base.Columns["idsotrudnika"];
                this.columnnakladnaya = base.Columns["nakladnaya"];
                this.columnkolichestvo = base.Columns["kolichestvo"];
                this.columndatavidachi = base.Columns["datavidachi"];
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columnidrashod = new global::System.Data.DataColumn("idrashod", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnidrashod);
                this.columnidklienta = new global::System.Data.DataColumn("idklienta", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnidklienta);
                this.columnidtovara = new global::System.Data.DataColumn("idtovara", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnidtovara);
                this.columnidsotrudnika = new global::System.Data.DataColumn("idsotrudnika", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnidsotrudnika);
                this.columnnakladnaya = new global::System.Data.DataColumn("nakladnaya", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnnakladnaya);
                this.columnkolichestvo = new global::System.Data.DataColumn("kolichestvo", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnkolichestvo);
                this.columndatavidachi = new global::System.Data.DataColumn("datavidachi", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columndatavidachi);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnidrashod}, true));
                this.columnidrashod.AutoIncrement = true;
                this.columnidrashod.AutoIncrementSeed = 1;
                this.columnidrashod.AllowDBNull = false;
                this.columnidrashod.ReadOnly = true;
                this.columnidrashod.Unique = true;
                this.columnidklienta.AllowDBNull = false;
                this.columnidtovara.AllowDBNull = false;
                this.columnidsotrudnika.AllowDBNull = false;
                this.columnnakladnaya.MaxLength = 10;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public RashodRow NewRashodRow()
            {
                return ((RashodRow)(this.NewRow()));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder)
            {
                return new RashodRow(builder);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType()
            {
                return typeof(RashodRow);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if ((this.RashodRowChanged != null))
                {
                    this.RashodRowChanged(this, new RashodRowChangeEvent(((RashodRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if ((this.RashodRowChanging != null))
                {
                    this.RashodRowChanging(this, new RashodRowChangeEvent(((RashodRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if ((this.RashodRowDeleted != null))
                {
                    this.RashodRowDeleted(this, new RashodRowChangeEvent(((RashodRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if ((this.RashodRowDeleting != null))
                {
                    this.RashodRowDeleting(this, new RashodRowChangeEvent(((RashodRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveRashodRow(RashodRow row)
            {
                this.Rows.Remove(row);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs)
            {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                SkladDataSet ds = new SkladDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "RashodDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace))
                {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try
                    {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); )
                        {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length))
                            {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length)
                                            && (s1.ReadByte() == s2.ReadByte())); )
                                {
                                    ;
                                }
                                if ((s1.Position == s1.Length))
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if ((s1 != null))
                        {
                            s1.Close();
                        }
                        if ((s2 != null))
                        {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }

        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class SotrudnikiDataTable : global::System.Data.TypedTableBase<SotrudnikiRow>
        {

            private global::System.Data.DataColumn columnidsotrudnika;

            private global::System.Data.DataColumn columnfam;

            private global::System.Data.DataColumn columnname;

            private global::System.Data.DataColumn columnotch;

            private global::System.Data.DataColumn columnbday;

            private global::System.Data.DataColumn columndolzhnost;

            private global::System.Data.DataColumn columnfio;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public SotrudnikiDataTable() :
                this(false)
            {
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public SotrudnikiDataTable(bool initExpressions)
            {
                this.TableName = "Sotrudniki";
                this.BeginInit();
                this.InitClass();
                if ((initExpressions == true))
                {
                    this.InitExpressions();
                }
                this.EndInit();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal SotrudnikiDataTable(global::System.Data.DataTable table)
            {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive))
                {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString()))
                {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace))
                {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected SotrudnikiDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base(info, context)
            {
                this.InitVars();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn idsotrudnikaColumn
            {
                get
                {
                    return this.columnidsotrudnika;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn famColumn
            {
                get
                {
                    return this.columnfam;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn nameColumn
            {
                get
                {
                    return this.columnname;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn otchColumn
            {
                get
                {
                    return this.columnotch;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn bdayColumn
            {
                get
                {
                    return this.columnbday;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn dolzhnostColumn
            {
                get
                {
                    return this.columndolzhnost;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn fioColumn
            {
                get
                {
                    return this.columnfio;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count
            {
                get
                {
                    return this.Rows.Count;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public SotrudnikiRow this[int index]
            {
                get
                {
                    return ((SotrudnikiRow)(this.Rows[index]));
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event SotrudnikiRowChangeEventHandler SotrudnikiRowChanging;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event SotrudnikiRowChangeEventHandler SotrudnikiRowChanged;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event SotrudnikiRowChangeEventHandler SotrudnikiRowDeleting;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event SotrudnikiRowChangeEventHandler SotrudnikiRowDeleted;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddSotrudnikiRow(SotrudnikiRow row)
            {
                this.Rows.Add(row);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public SotrudnikiRow AddSotrudnikiRow(string fam, string name, string otch, System.DateTime bday, string dolzhnost, string fio)
            {
                SotrudnikiRow rowSotrudnikiRow = ((SotrudnikiRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        fam,
                        name,
                        otch,
                        bday,
                        dolzhnost,
                        fio};
                rowSotrudnikiRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowSotrudnikiRow);
                return rowSotrudnikiRow;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public SotrudnikiRow AddSotrudnikiRow(string fam, string name, string otch, System.DateTime bday, string dolzhnost)
            {
                SotrudnikiRow rowSotrudnikiRow = ((SotrudnikiRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        fam,
                        name,
                        otch,
                        bday,
                        dolzhnost,
                        null};
                rowSotrudnikiRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowSotrudnikiRow);
                return rowSotrudnikiRow;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public SotrudnikiRow FindByidsotrudnika(int idsotrudnika)
            {
                return ((SotrudnikiRow)(this.Rows.Find(new object[] {
                            idsotrudnika})));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone()
            {
                SotrudnikiDataTable cln = ((SotrudnikiDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance()
            {
                return new SotrudnikiDataTable();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars()
            {
                this.columnidsotrudnika = base.Columns["idsotrudnika"];
                this.columnfam = base.Columns["fam"];
                this.columnname = base.Columns["name"];
                this.columnotch = base.Columns["otch"];
                this.columnbday = base.Columns["bday"];
                this.columndolzhnost = base.Columns["dolzhnost"];
                this.columnfio = base.Columns["fio"];
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columnidsotrudnika = new global::System.Data.DataColumn("idsotrudnika", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnidsotrudnika);
                this.columnfam = new global::System.Data.DataColumn("fam", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnfam);
                this.columnname = new global::System.Data.DataColumn("name", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnname);
                this.columnotch = new global::System.Data.DataColumn("otch", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnotch);
                this.columnbday = new global::System.Data.DataColumn("bday", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnbday);
                this.columndolzhnost = new global::System.Data.DataColumn("dolzhnost", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columndolzhnost);
                this.columnfio = new global::System.Data.DataColumn("fio", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnfio);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnidsotrudnika}, true));
                this.columnidsotrudnika.AutoIncrement = true;
                this.columnidsotrudnika.AutoIncrementSeed = 1;
                this.columnidsotrudnika.AllowDBNull = false;
                this.columnidsotrudnika.ReadOnly = true;
                this.columnidsotrudnika.Unique = true;
                this.columnfam.MaxLength = 50;
                this.columnname.MaxLength = 50;
                this.columnotch.MaxLength = 50;
                this.columndolzhnost.MaxLength = 50;
                this.columnfio.ReadOnly = true;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public SotrudnikiRow NewSotrudnikiRow()
            {
                return ((SotrudnikiRow)(this.NewRow()));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder)
            {
                return new SotrudnikiRow(builder);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType()
            {
                return typeof(SotrudnikiRow);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitExpressions()
            {
                this.fioColumn.Expression = "fam + \' \'+substring(name, 1,1) + \'.\'+substring(otch,1,1) + \'.\'";
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if ((this.SotrudnikiRowChanged != null))
                {
                    this.SotrudnikiRowChanged(this, new SotrudnikiRowChangeEvent(((SotrudnikiRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if ((this.SotrudnikiRowChanging != null))
                {
                    this.SotrudnikiRowChanging(this, new SotrudnikiRowChangeEvent(((SotrudnikiRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if ((this.SotrudnikiRowDeleted != null))
                {
                    this.SotrudnikiRowDeleted(this, new SotrudnikiRowChangeEvent(((SotrudnikiRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if ((this.SotrudnikiRowDeleting != null))
                {
                    this.SotrudnikiRowDeleting(this, new SotrudnikiRowChangeEvent(((SotrudnikiRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveSotrudnikiRow(SotrudnikiRow row)
            {
                this.Rows.Remove(row);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs)
            {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                SkladDataSet ds = new SkladDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "SotrudnikiDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace))
                {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try
                    {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); )
                        {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length))
                            {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length)
                                            && (s1.ReadByte() == s2.ReadByte())); )
                                {
                                    ;
                                }
                                if ((s1.Position == s1.Length))
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if ((s1 != null))
                        {
                            s1.Close();
                        }
                        if ((s2 != null))
                        {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }

        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class TovariDataTable : global::System.Data.TypedTableBase<TovariRow>
        {

            private global::System.Data.DataColumn columnidtovara;

            private global::System.Data.DataColumn columnnametovara;

            private global::System.Data.DataColumn columnedizmer;

            private global::System.Data.DataColumn columnkolichestvo;

            private global::System.Data.DataColumn columnprimechanie;

            private global::System.Data.DataColumn columncena;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TovariDataTable()
            {
                this.TableName = "Tovari";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal TovariDataTable(global::System.Data.DataTable table)
            {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive))
                {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString()))
                {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace))
                {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected TovariDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base(info, context)
            {
                this.InitVars();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn idtovaraColumn
            {
                get
                {
                    return this.columnidtovara;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn nametovaraColumn
            {
                get
                {
                    return this.columnnametovara;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn edizmerColumn
            {
                get
                {
                    return this.columnedizmer;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn kolichestvoColumn
            {
                get
                {
                    return this.columnkolichestvo;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn primechanieColumn
            {
                get
                {
                    return this.columnprimechanie;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn cenaColumn
            {
                get
                {
                    return this.columncena;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count
            {
                get
                {
                    return this.Rows.Count;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TovariRow this[int index]
            {
                get
                {
                    return ((TovariRow)(this.Rows[index]));
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TovariRowChangeEventHandler TovariRowChanging;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TovariRowChangeEventHandler TovariRowChanged;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TovariRowChangeEventHandler TovariRowDeleting;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event TovariRowChangeEventHandler TovariRowDeleted;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddTovariRow(TovariRow row)
            {
                this.Rows.Add(row);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TovariRow AddTovariRow(string nametovara, string edizmer, int kolichestvo, string primechanie, decimal cena)
            {
                TovariRow rowTovariRow = ((TovariRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        nametovara,
                        edizmer,
                        kolichestvo,
                        primechanie,
                        cena};
                rowTovariRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowTovariRow);
                return rowTovariRow;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TovariRow FindByidtovara(int idtovara)
            {
                return ((TovariRow)(this.Rows.Find(new object[] {
                            idtovara})));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone()
            {
                TovariDataTable cln = ((TovariDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance()
            {
                return new TovariDataTable();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars()
            {
                this.columnidtovara = base.Columns["idtovara"];
                this.columnnametovara = base.Columns["nametovara"];
                this.columnedizmer = base.Columns["edizmer"];
                this.columnkolichestvo = base.Columns["kolichestvo"];
                this.columnprimechanie = base.Columns["primechanie"];
                this.columncena = base.Columns["cena"];
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columnidtovara = new global::System.Data.DataColumn("idtovara", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnidtovara);
                this.columnnametovara = new global::System.Data.DataColumn("nametovara", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnnametovara);
                this.columnedizmer = new global::System.Data.DataColumn("edizmer", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnedizmer);
                this.columnkolichestvo = new global::System.Data.DataColumn("kolichestvo", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnkolichestvo);
                this.columnprimechanie = new global::System.Data.DataColumn("primechanie", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnprimechanie);
                this.columncena = new global::System.Data.DataColumn("cena", typeof(decimal), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columncena);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnidtovara}, true));
                this.columnidtovara.AutoIncrement = true;
                this.columnidtovara.AutoIncrementSeed = 1;
                this.columnidtovara.AllowDBNull = false;
                this.columnidtovara.ReadOnly = true;
                this.columnidtovara.Unique = true;
                this.columnnametovara.MaxLength = 100;
                this.columnedizmer.MaxLength = 7;
                this.columnprimechanie.MaxLength = 100;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TovariRow NewTovariRow()
            {
                return ((TovariRow)(this.NewRow()));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder)
            {
                return new TovariRow(builder);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType()
            {
                return typeof(TovariRow);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if ((this.TovariRowChanged != null))
                {
                    this.TovariRowChanged(this, new TovariRowChangeEvent(((TovariRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if ((this.TovariRowChanging != null))
                {
                    this.TovariRowChanging(this, new TovariRowChangeEvent(((TovariRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if ((this.TovariRowDeleted != null))
                {
                    this.TovariRowDeleted(this, new TovariRowChangeEvent(((TovariRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if ((this.TovariRowDeleting != null))
                {
                    this.TovariRowDeleting(this, new TovariRowChangeEvent(((TovariRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveTovariRow(TovariRow row)
            {
                this.Rows.Remove(row);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs)
            {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                SkladDataSet ds = new SkladDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "TovariDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace))
                {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try
                    {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); )
                        {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length))
                            {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length)
                                            && (s1.ReadByte() == s2.ReadByte())); )
                                {
                                    ;
                                }
                                if ((s1.Position == s1.Length))
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if ((s1 != null))
                        {
                            s1.Close();
                        }
                        if ((s2 != null))
                        {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }

        public partial class KlientiRow : global::System.Data.DataRow
        {

            private KlientiDataTable tableKlienti;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal KlientiRow(global::System.Data.DataRowBuilder rb) :
                base(rb)
            {
                this.tableKlienti = ((KlientiDataTable)(this.Table));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idklienta
            {
                get
                {
                    return ((int)(this[this.tableKlienti.idklientaColumn]));
                }
                set
                {
                    this[this.tableKlienti.idklientaColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string nameklienta
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableKlienti.nameklientaColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'nameklienta\' in table \'Klienti\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableKlienti.nameklientaColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string gorod
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableKlienti.gorodColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'gorod\' in table \'Klienti\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableKlienti.gorodColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ulica
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableKlienti.ulicaColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'ulica\' in table \'Klienti\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableKlienti.ulicaColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string dom
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableKlienti.domColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'dom\' in table \'Klienti\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableKlienti.domColumn] = value;
                }
            }

            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string telefon
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableKlienti.telefonColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'telefon\' in table \'Klienti\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableKlienti.telefonColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string primechanie
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableKlienti.primechanieColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'primechanie\' in table \'Klienti\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableKlienti.primechanieColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsnameklientaNull()
            {
                return this.IsNull(this.tableKlienti.nameklientaColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetnameklientaNull()
            {
                this[this.tableKlienti.nameklientaColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsgorodNull()
            {
                return this.IsNull(this.tableKlienti.gorodColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetgorodNull()
            {
                this[this.tableKlienti.gorodColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsulicaNull()
            {
                return this.IsNull(this.tableKlienti.ulicaColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetulicaNull()
            {
                this[this.tableKlienti.ulicaColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsdomNull()
            {
                return this.IsNull(this.tableKlienti.domColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetdomNull()
            {
                this[this.tableKlienti.domColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IstelefonNull()
            {
                return this.IsNull(this.tableKlienti.telefonColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SettelefonNull()
            {
                this[this.tableKlienti.telefonColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsprimechanieNull()
            {
                return this.IsNull(this.tableKlienti.primechanieColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetprimechanieNull()
            {
                this[this.tableKlienti.primechanieColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public RashodRow[] GetRashodRows()
            {
                if ((this.Table.ChildRelations["KlientiRashod"] == null))
                {
                    return new RashodRow[0];
                }
                else
                {
                    return ((RashodRow[])(base.GetChildRows(this.Table.ChildRelations["KlientiRashod"])));
                }
            }
        }

        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class PostavshikiRow : global::System.Data.DataRow
        {

            private PostavshikiDataTable tablePostavshiki;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal PostavshikiRow(global::System.Data.DataRowBuilder rb) :
                base(rb)
            {
                this.tablePostavshiki = ((PostavshikiDataTable)(this.Table));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idpostavshik
            {
                get
                {
                    return ((int)(this[this.tablePostavshiki.idpostavshikColumn]));
                }
                set
                {
                    this[this.tablePostavshiki.idpostavshikColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string namepostavshik
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tablePostavshiki.namepostavshikColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'namepostavshik\' in table \'Postavshiki\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tablePostavshiki.namepostavshikColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string gorod
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tablePostavshiki.gorodColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'gorod\' in table \'Postavshiki\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tablePostavshiki.gorodColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ulica
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tablePostavshiki.ulicaColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'ulica\' in table \'Postavshiki\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tablePostavshiki.ulicaColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string dom
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tablePostavshiki.domColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'dom\' in table \'Postavshiki\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tablePostavshiki.domColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string telefon
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tablePostavshiki.telefonColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'telefon\' in table \'Postavshiki\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tablePostavshiki.telefonColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string primechanie
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tablePostavshiki.primechanieColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'primechanie\' in table \'Postavshiki\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tablePostavshiki.primechanieColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsnamepostavshikNull()
            {
                return this.IsNull(this.tablePostavshiki.namepostavshikColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetnamepostavshikNull()
            {
                this[this.tablePostavshiki.namepostavshikColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsgorodNull()
            {
                return this.IsNull(this.tablePostavshiki.gorodColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetgorodNull()
            {
                this[this.tablePostavshiki.gorodColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsulicaNull()
            {
                return this.IsNull(this.tablePostavshiki.ulicaColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetulicaNull()
            {
                this[this.tablePostavshiki.ulicaColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsdomNull()
            {
                return this.IsNull(this.tablePostavshiki.domColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetdomNull()
            {
                this[this.tablePostavshiki.domColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IstelefonNull()
            {
                return this.IsNull(this.tablePostavshiki.telefonColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SettelefonNull()
            {
                this[this.tablePostavshiki.telefonColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsprimechanieNull()
            {
                return this.IsNull(this.tablePostavshiki.primechanieColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetprimechanieNull()
            {
                this[this.tablePostavshiki.primechanieColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PrihodRow[] GetPrihodRows()
            {
                if ((this.Table.ChildRelations["PostavshikiPrihod"] == null))
                {
                    return new PrihodRow[0];
                }
                else
                {
                    return ((PrihodRow[])(base.GetChildRows(this.Table.ChildRelations["PostavshikiPrihod"])));
                }
            }
        }

        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class PrihodRow : global::System.Data.DataRow
        {

            private PrihodDataTable tablePrihod;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal PrihodRow(global::System.Data.DataRowBuilder rb) :
                base(rb)
            {
                this.tablePrihod = ((PrihodDataTable)(this.Table));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idprihod
            {
                get
                {
                    return ((int)(this[this.tablePrihod.idprihodColumn]));
                }
                set
                {
                    this[this.tablePrihod.idprihodColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idpostavshik
            {
                get
                {
                    return ((int)(this[this.tablePrihod.idpostavshikColumn]));
                }
                set
                {
                    this[this.tablePrihod.idpostavshikColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idtovara
            {
                get
                {
                    return ((int)(this[this.tablePrihod.idtovaraColumn]));
                }
                set
                {
                    this[this.tablePrihod.idtovaraColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idsotrudnika
            {
                get
                {
                    return ((int)(this[this.tablePrihod.idsotrudnikaColumn]));
                }
                set
                {
                    this[this.tablePrihod.idsotrudnikaColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string nakladnaya
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tablePrihod.nakladnayaColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'nakladnaya\' in table \'Prihod\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tablePrihod.nakladnayaColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int kolichestvo
            {
                get
                {
                    try
                    {
                        return ((int)(this[this.tablePrihod.kolichestvoColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'kolichestvo\' in table \'Prihod\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tablePrihod.kolichestvoColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.DateTime datapolucheniya
            {
                get
                {
                    try
                    {
                        return ((global::System.DateTime)(this[this.tablePrihod.datapolucheniyaColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'datapolucheniya\' in table \'Prihod\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tablePrihod.datapolucheniyaColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PostavshikiRow PostavshikiRow
            {
                get
                {
                    return ((PostavshikiRow)(this.GetParentRow(this.Table.ParentRelations["PostavshikiPrihod"])));
                }
                set
                {
                    this.SetParentRow(value, this.Table.ParentRelations["PostavshikiPrihod"]);
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public SotrudnikiRow SotrudnikiRow
            {
                get
                {
                    return ((SotrudnikiRow)(this.GetParentRow(this.Table.ParentRelations["SotrudnikPrihod"])));
                }
                set
                {
                    this.SetParentRow(value, this.Table.ParentRelations["SotrudnikPrihod"]);
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TovariRow TovariRow
            {
                get
                {
                    return ((TovariRow)(this.GetParentRow(this.Table.ParentRelations["TovariPrihod"])));
                }
                set
                {
                    this.SetParentRow(value, this.Table.ParentRelations["TovariPrihod"]);
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsnakladnayaNull()
            {
                return this.IsNull(this.tablePrihod.nakladnayaColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetnakladnayaNull()
            {
                this[this.tablePrihod.nakladnayaColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IskolichestvoNull()
            {
                return this.IsNull(this.tablePrihod.kolichestvoColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetkolichestvoNull()
            {
                this[this.tablePrihod.kolichestvoColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsdatapolucheniyaNull()
            {
                return this.IsNull(this.tablePrihod.datapolucheniyaColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetdatapolucheniyaNull()
            {
                this[this.tablePrihod.datapolucheniyaColumn] = global::System.Convert.DBNull;
            }
        }

        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class RashodRow : global::System.Data.DataRow
        {

            private RashodDataTable tableRashod;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal RashodRow(global::System.Data.DataRowBuilder rb) :
                base(rb)
            {
                this.tableRashod = ((RashodDataTable)(this.Table));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idrashod
            {
                get
                {
                    return ((int)(this[this.tableRashod.idrashodColumn]));
                }
                set
                {
                    this[this.tableRashod.idrashodColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idklienta
            {
                get
                {
                    return ((int)(this[this.tableRashod.idklientaColumn]));
                }
                set
                {
                    this[this.tableRashod.idklientaColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idtovara
            {
                get
                {
                    return ((int)(this[this.tableRashod.idtovaraColumn]));
                }
                set
                {
                    this[this.tableRashod.idtovaraColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idsotrudnika
            {
                get
                {
                    return ((int)(this[this.tableRashod.idsotrudnikaColumn]));
                }
                set
                {
                    this[this.tableRashod.idsotrudnikaColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string nakladnaya
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableRashod.nakladnayaColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'nakladnaya\' in table \'Rashod\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableRashod.nakladnayaColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int kolichestvo
            {
                get
                {
                    try
                    {
                        return ((int)(this[this.tableRashod.kolichestvoColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'kolichestvo\' in table \'Rashod\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableRashod.kolichestvoColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.DateTime datavidachi
            {
                get
                {
                    try
                    {
                        return ((global::System.DateTime)(this[this.tableRashod.datavidachiColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'datavidachi\' in table \'Rashod\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableRashod.datavidachiColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public KlientiRow KlientiRow
            {
                get
                {
                    return ((KlientiRow)(this.GetParentRow(this.Table.ParentRelations["KlientiRashod"])));
                }
                set
                {
                    this.SetParentRow(value, this.Table.ParentRelations["KlientiRashod"]);
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public SotrudnikiRow SotrudnikiRow
            {
                get
                {
                    return ((SotrudnikiRow)(this.GetParentRow(this.Table.ParentRelations["SotrudnikiRashod"])));
                }
                set
                {
                    this.SetParentRow(value, this.Table.ParentRelations["SotrudnikiRashod"]);
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TovariRow TovariRow
            {
                get
                {
                    return ((TovariRow)(this.GetParentRow(this.Table.ParentRelations["TovariRashod"])));
                }
                set
                {
                    this.SetParentRow(value, this.Table.ParentRelations["TovariRashod"]);
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsnakladnayaNull()
            {
                return this.IsNull(this.tableRashod.nakladnayaColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetnakladnayaNull()
            {
                this[this.tableRashod.nakladnayaColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IskolichestvoNull()
            {
                return this.IsNull(this.tableRashod.kolichestvoColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetkolichestvoNull()
            {
                this[this.tableRashod.kolichestvoColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsdatavidachiNull()
            {
                return this.IsNull(this.tableRashod.datavidachiColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetdatavidachiNull()
            {
                this[this.tableRashod.datavidachiColumn] = global::System.Convert.DBNull;
            }
        }

        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class SotrudnikiRow : global::System.Data.DataRow
        {

            private SotrudnikiDataTable tableSotrudniki;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal SotrudnikiRow(global::System.Data.DataRowBuilder rb) :
                base(rb)
            {
                this.tableSotrudniki = ((SotrudnikiDataTable)(this.Table));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idsotrudnika
            {
                get
                {
                    return ((int)(this[this.tableSotrudniki.idsotrudnikaColumn]));
                }
                set
                {
                    this[this.tableSotrudniki.idsotrudnikaColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string fam
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableSotrudniki.famColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'fam\' in table \'Sotrudniki\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableSotrudniki.famColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string name
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableSotrudniki.nameColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'name\' in table \'Sotrudniki\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableSotrudniki.nameColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string otch
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableSotrudniki.otchColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'otch\' in table \'Sotrudniki\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableSotrudniki.otchColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.DateTime bday
            {
                get
                {
                    try
                    {
                        return ((global::System.DateTime)(this[this.tableSotrudniki.bdayColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'bday\' in table \'Sotrudniki\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableSotrudniki.bdayColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string dolzhnost
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableSotrudniki.dolzhnostColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'dolzhnost\' in table \'Sotrudniki\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableSotrudniki.dolzhnostColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string fio
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableSotrudniki.fioColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'fio\' in table \'Sotrudniki\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableSotrudniki.fioColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsfamNull()
            {
                return this.IsNull(this.tableSotrudniki.famColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetfamNull()
            {
                this[this.tableSotrudniki.famColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsnameNull()
            {
                return this.IsNull(this.tableSotrudniki.nameColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetnameNull()
            {
                this[this.tableSotrudniki.nameColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsotchNull()
            {
                return this.IsNull(this.tableSotrudniki.otchColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetotchNull()
            {
                this[this.tableSotrudniki.otchColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsbdayNull()
            {
                return this.IsNull(this.tableSotrudniki.bdayColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetbdayNull()
            {
                this[this.tableSotrudniki.bdayColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsdolzhnostNull()
            {
                return this.IsNull(this.tableSotrudniki.dolzhnostColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetdolzhnostNull()
            {
                this[this.tableSotrudniki.dolzhnostColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsfioNull()
            {
                return this.IsNull(this.tableSotrudniki.fioColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetfioNull()
            {
                this[this.tableSotrudniki.fioColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PrihodRow[] GetPrihodRows()
            {
                if ((this.Table.ChildRelations["SotrudnikPrihod"] == null))
                {
                    return new PrihodRow[0];
                }
                else
                {
                    return ((PrihodRow[])(base.GetChildRows(this.Table.ChildRelations["SotrudnikPrihod"])));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public RashodRow[] GetRashodRows()
            {
                if ((this.Table.ChildRelations["SotrudnikiRashod"] == null))
                {
                    return new RashodRow[0];
                }
                else
                {
                    return ((RashodRow[])(base.GetChildRows(this.Table.ChildRelations["SotrudnikiRashod"])));
                }
            }
        }

        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class TovariRow : global::System.Data.DataRow
        {

            private TovariDataTable tableTovari;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal TovariRow(global::System.Data.DataRowBuilder rb) :
                base(rb)
            {
                this.tableTovari = ((TovariDataTable)(this.Table));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idtovara
            {
                get
                {
                    return ((int)(this[this.tableTovari.idtovaraColumn]));
                }
                set
                {
                    this[this.tableTovari.idtovaraColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string nametovara
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableTovari.nametovaraColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'nametovara\' in table \'Tovari\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableTovari.nametovaraColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string edizmer
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableTovari.edizmerColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'edizmer\' in table \'Tovari\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableTovari.edizmerColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int kolichestvo
            {
                get
                {
                    try
                    {
                        return ((int)(this[this.tableTovari.kolichestvoColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'kolichestvo\' in table \'Tovari\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableTovari.kolichestvoColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string primechanie
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableTovari.primechanieColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'primechanie\' in table \'Tovari\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableTovari.primechanieColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public decimal cena
            {
                get
                {
                    try
                    {
                        return ((decimal)(this[this.tableTovari.cenaColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'cena\' in table \'Tovari\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableTovari.cenaColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsnametovaraNull()
            {
                return this.IsNull(this.tableTovari.nametovaraColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetnametovaraNull()
            {
                this[this.tableTovari.nametovaraColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsedizmerNull()
            {
                return this.IsNull(this.tableTovari.edizmerColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetedizmerNull()
            {
                this[this.tableTovari.edizmerColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IskolichestvoNull()
            {
                return this.IsNull(this.tableTovari.kolichestvoColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetkolichestvoNull()
            {
                this[this.tableTovari.kolichestvoColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsprimechanieNull()
            {
                return this.IsNull(this.tableTovari.primechanieColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetprimechanieNull()
            {
                this[this.tableTovari.primechanieColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IscenaNull()
            {
                return this.IsNull(this.tableTovari.cenaColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetcenaNull()
            {
                this[this.tableTovari.cenaColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PrihodRow[] GetPrihodRows()
            {
                if ((this.Table.ChildRelations["TovariPrihod"] == null))
                {
                    return new PrihodRow[0];
                }
                else
                {
                    return ((PrihodRow[])(base.GetChildRows(this.Table.ChildRelations["TovariPrihod"])));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public RashodRow[] GetRashodRows()
            {
                if ((this.Table.ChildRelations["TovariRashod"] == null))
                {
                    return new RashodRow[0];
                }
                else
                {
                    return ((RashodRow[])(base.GetChildRows(this.Table.ChildRelations["TovariRashod"])));
                }
            }
        }

        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class KlientiRowChangeEvent : global::System.EventArgs
        {

            private KlientiRow eventRow;

            private global::System.Data.DataRowAction eventAction;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public KlientiRowChangeEvent(KlientiRow row, global::System.Data.DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public KlientiRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }
        }

        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class PostavshikiRowChangeEvent : global::System.EventArgs
        {

            private PostavshikiRow eventRow;

            private global::System.Data.DataRowAction eventAction;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PostavshikiRowChangeEvent(PostavshikiRow row, global::System.Data.DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PostavshikiRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }
        }

        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class PrihodRowChangeEvent : global::System.EventArgs
        {

            private PrihodRow eventRow;

            private global::System.Data.DataRowAction eventAction;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PrihodRowChangeEvent(PrihodRow row, global::System.Data.DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public PrihodRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }
        }


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class RashodRowChangeEvent : global::System.EventArgs
        {

            private RashodRow eventRow;

            private global::System.Data.DataRowAction eventAction;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public RashodRowChangeEvent(RashodRow row, global::System.Data.DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public RashodRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }
        }

        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class SotrudnikiRowChangeEvent : global::System.EventArgs
        {

            private SotrudnikiRow eventRow;

            private global::System.Data.DataRowAction eventAction;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public SotrudnikiRowChangeEvent(SotrudnikiRow row, global::System.Data.DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public SotrudnikiRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class TovariRowChangeEvent : global::System.EventArgs
        {

            private TovariRow eventRow;

            private global::System.Data.DataRowAction eventAction;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TovariRowChangeEvent(TovariRow row, global::System.Data.DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public TovariRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }
        }
    }
}
namespace SkladSUBD.SkladDataSetTableAdapters
{


    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class KlientiTableAdapter : global::System.ComponentModel.Component
    {

        private global::System.Data.SqlServerCe.SqlCeDataAdapter _adapter;

        private global::System.Data.SqlServerCe.SqlCeConnection _connection;

        private global::System.Data.SqlServerCe.SqlCeTransaction _transaction;

        private global::System.Data.SqlServerCe.SqlCeCommand[] _commandCollection;

        private bool _clearBeforeFill;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public KlientiTableAdapter()
        {
            this.ClearBeforeFill = true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected internal global::System.Data.SqlServerCe.SqlCeDataAdapter Adapter
        {
            get
            {
                if ((this._adapter == null))
                {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.SqlServerCe.SqlCeConnection Connection
        {
            get
            {
                if ((this._connection == null))
                {
                    this.InitConnection();
                }
                return this._connection;
            }
            set
            {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null))
                {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null))
                {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null))
                {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    if ((this.CommandCollection[i] != null))
                    {
                        ((global::System.Data.SqlServerCe.SqlCeCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.SqlServerCe.SqlCeTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
            set
            {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.DeleteCommand != null)))
                {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.InsertCommand != null)))
                {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.UpdateCommand != null)))
                {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected global::System.Data.SqlServerCe.SqlCeCommand[] CommandCollection
        {
            get
            {
                if ((this._commandCollection == null))
                {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool ClearBeforeFill
        {
            get
            {
                return this._clearBeforeFill;
            }
            set
            {
                this._clearBeforeFill = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter()
        {
            this._adapter = new global::System.Data.SqlServerCe.SqlCeDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Klienti";
            tableMapping.ColumnMappings.Add("idklienta", "idklienta");
            tableMapping.ColumnMappings.Add("nameklienta", "nameklienta");
            tableMapping.ColumnMappings.Add("gorod", "gorod");
            tableMapping.ColumnMappings.Add("ulica", "ulica");
            tableMapping.ColumnMappings.Add("dom", "dom");
            tableMapping.ColumnMappings.Add("telefon", "telefon");
            tableMapping.ColumnMappings.Add("primechanie", "primechanie");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM [Klienti] WHERE (([idklienta] = @p1))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p1", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idklienta", global::System.Data.DataRowVersion.Original, null));
            this._adapter.InsertCommand = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO [Klienti] ([nameklienta], [gorod], [ulica], [dom], [tel" +
                "efon], [primechanie]) VALUES (@p1, @p2, @p3, @p4, @p7, @p8)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p1", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "nameklienta", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p2", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "gorod", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p3", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "ulica", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p4", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "dom", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p7", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "telefon", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p8", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "primechanie", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = "UPDATE [Klienti] SET [nameklienta] = @p1, [gorod] = @p2, [ulica] = @p3, [dom] = @" +
                "p4, [telefon] = @p7, [primechanie] = @p8 WHERE (([idkl" +
                "ienta] = @p9))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p1", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "nameklienta", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p2", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "gorod", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p3", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "ulica", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p4", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "dom", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p7", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "telefon", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p8", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "primechanie", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p9", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idklienta", global::System.Data.DataRowVersion.Original, null));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitConnection()
        {
            this._connection = new global::System.Data.SqlServerCe.SqlCeConnection();
            this._connection.ConnectionString = global::SkladSUBD.Properties.Settings.Default.SkladConnectionString;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection()
        {
            this._commandCollection = new global::System.Data.SqlServerCe.SqlCeCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT [idklienta], [nameklienta], [gorod], [ulica], [dom], [telefo" +
                "n], [primechanie] FROM [Klienti]";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(SkladDataSet.KlientiDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true))
            {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual SkladDataSet.KlientiDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            SkladDataSet.KlientiDataTable dataTable = new SkladDataSet.KlientiDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(SkladDataSet.KlientiDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(SkladDataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "Klienti");
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow)
        {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int p1)
        {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(p1));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8)
        {
            if ((p1 == null))
            {
                this.Adapter.InsertCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(p1));
            }
            if ((p2 == null))
            {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(p2));
            }
            if ((p3 == null))
            {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[2].Value = ((string)(p3));
            }
            if ((p4 == null))
            {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[3].Value = ((string)(p4));
            }
            if ((p5 == null))
            {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[4].Value = ((string)(p5));
            }
            if ((p6 == null))
            {
                this.Adapter.InsertCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[5].Value = ((string)(p6));
            }
            if ((p7 == null))
            {
                this.Adapter.InsertCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[6].Value = ((string)(p7));
            }
            if ((p8 == null))
            {
                this.Adapter.InsertCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[7].Value = ((string)(p8));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, int p9)
        {
            if ((p1 == null))
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(p1));
            }
            if ((p2 == null))
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(p2));
            }
            if ((p3 == null))
            {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(p3));
            }
            if ((p4 == null))
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((string)(p4));
            }
            if ((p5 == null))
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((string)(p5));
            }
            if ((p6 == null))
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((string)(p6));
            }
            if ((p7 == null))
            {
                this.Adapter.UpdateCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((string)(p7));
            }
            if ((p8 == null))
            {
                this.Adapter.UpdateCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[7].Value = ((string)(p8));
            }
            this.Adapter.UpdateCommand.Parameters[8].Value = ((int)(p9));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
    }

    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class PostavshikiTableAdapter : global::System.ComponentModel.Component
    {

        private global::System.Data.SqlServerCe.SqlCeDataAdapter _adapter;

        private global::System.Data.SqlServerCe.SqlCeConnection _connection;

        private global::System.Data.SqlServerCe.SqlCeTransaction _transaction;

        private global::System.Data.SqlServerCe.SqlCeCommand[] _commandCollection;

        private bool _clearBeforeFill;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public PostavshikiTableAdapter()
        {
            this.ClearBeforeFill = true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected internal global::System.Data.SqlServerCe.SqlCeDataAdapter Adapter
        {
            get
            {
                if ((this._adapter == null))
                {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.SqlServerCe.SqlCeConnection Connection
        {
            get
            {
                if ((this._connection == null))
                {
                    this.InitConnection();
                }
                return this._connection;
            }
            set
            {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null))
                {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null))
                {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null))
                {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    if ((this.CommandCollection[i] != null))
                    {
                        ((global::System.Data.SqlServerCe.SqlCeCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.SqlServerCe.SqlCeTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
            set
            {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.DeleteCommand != null)))
                {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.InsertCommand != null)))
                {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.UpdateCommand != null)))
                {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected global::System.Data.SqlServerCe.SqlCeCommand[] CommandCollection
        {
            get
            {
                if ((this._commandCollection == null))
                {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool ClearBeforeFill
        {
            get
            {
                return this._clearBeforeFill;
            }
            set
            {
                this._clearBeforeFill = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter()
        {
            this._adapter = new global::System.Data.SqlServerCe.SqlCeDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Postavshiki";
            tableMapping.ColumnMappings.Add("idpostavshik", "idpostavshik");
            tableMapping.ColumnMappings.Add("namepostavshik", "namepostavshik");
            tableMapping.ColumnMappings.Add("gorod", "gorod");
            tableMapping.ColumnMappings.Add("ulica", "ulica");
            tableMapping.ColumnMappings.Add("dom", "dom");
            tableMapping.ColumnMappings.Add("telefon", "telefon");
            tableMapping.ColumnMappings.Add("primechanie", "primechanie");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM [Postavshiki] WHERE (([idpostavshik] = @p1))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p1", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idpostavshik", global::System.Data.DataRowVersion.Original, null));
            this._adapter.InsertCommand = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO [Postavshiki] ([namepostavshik], [gorod], [ulica], [dom], [telefon], [primechanie]) VALUES (@p1, @p2, @p3, @p4, @p7, @p8)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p1", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "namepostavshik", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p2", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "gorod", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p3", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "ulica", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p4", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "dom", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p7", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "telefon", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p8", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "primechanie", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = "UPDATE [Postavshiki] SET [namepostavshik] = @p1, [gorod] = @p2, [ulica] = @p3, [d" +
                "om] = @p4, [telefon] = @p7, [primechanie] = @p8 WHERE " +
                "(([idpostavshik] = @p9))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p1", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "namepostavshik", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p2", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "gorod", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p3", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "ulica", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p4", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "dom", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p7", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "telefon", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p8", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "primechanie", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p9", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idpostavshik", global::System.Data.DataRowVersion.Original, null));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitConnection()
        {
            this._connection = new global::System.Data.SqlServerCe.SqlCeConnection();
            this._connection.ConnectionString = global::SkladSUBD.Properties.Settings.Default.SkladConnectionString;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection()
        {
            this._commandCollection = new global::System.Data.SqlServerCe.SqlCeCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT [idpostavshik], [namepostavshik], [gorod], [ulica], [dom], [" +
                "telefon], [primechanie] FROM [Postavshiki]";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(SkladDataSet.PostavshikiDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true))
            {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual SkladDataSet.PostavshikiDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            SkladDataSet.PostavshikiDataTable dataTable = new SkladDataSet.PostavshikiDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(SkladDataSet.PostavshikiDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(SkladDataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "Postavshiki");
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow)
        {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int p1)
        {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(p1));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string p1, string p2, string p3, string p4, string p7, string p8)
        {
            if ((p1 == null))
            {
                this.Adapter.InsertCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(p1));
            }
            if ((p2 == null))
            {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(p2));
            }
            if ((p3 == null))
            {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[2].Value = ((string)(p3));
            }
            if ((p4 == null))
            {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[3].Value = ((string)(p4));
            }
            if ((p7 == null))
            {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[4].Value = ((string)(p7));
            }
            if ((p8 == null))
            {
                this.Adapter.InsertCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[5].Value = ((string)(p8));
            }

            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string p1, string p2, string p3, string p4, string p7, string p8, int p9)
        {
            if ((p1 == null))
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(p1));
            }
            if ((p2 == null))
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(p2));
            }
            if ((p3 == null))
            {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(p3));
            }
            if ((p4 == null))
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((string)(p4));
            }
            if ((p7 == null))
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((string)(p7));
            }
            if ((p8 == null))
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((string)(p8));
            }

            this.Adapter.UpdateCommand.Parameters[8].Value = ((int)(p9));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
    }

    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class PrihodTableAdapter : global::System.ComponentModel.Component
    {

        private global::System.Data.SqlServerCe.SqlCeDataAdapter _adapter;

        private global::System.Data.SqlServerCe.SqlCeConnection _connection;

        private global::System.Data.SqlServerCe.SqlCeTransaction _transaction;

        private global::System.Data.SqlServerCe.SqlCeCommand[] _commandCollection;

        private bool _clearBeforeFill;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public PrihodTableAdapter()
        {
            this.ClearBeforeFill = true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected internal global::System.Data.SqlServerCe.SqlCeDataAdapter Adapter
        {
            get
            {
                if ((this._adapter == null))
                {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.SqlServerCe.SqlCeConnection Connection
        {
            get
            {
                if ((this._connection == null))
                {
                    this.InitConnection();
                }
                return this._connection;
            }
            set
            {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null))
                {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null))
                {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null))
                {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    if ((this.CommandCollection[i] != null))
                    {
                        ((global::System.Data.SqlServerCe.SqlCeCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.SqlServerCe.SqlCeTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
            set
            {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.DeleteCommand != null)))
                {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.InsertCommand != null)))
                {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.UpdateCommand != null)))
                {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected global::System.Data.SqlServerCe.SqlCeCommand[] CommandCollection
        {
            get
            {
                if ((this._commandCollection == null))
                {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool ClearBeforeFill
        {
            get
            {
                return this._clearBeforeFill;
            }
            set
            {
                this._clearBeforeFill = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter()
        {
            this._adapter = new global::System.Data.SqlServerCe.SqlCeDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Prihod";
            tableMapping.ColumnMappings.Add("idprihod", "idprihod");
            tableMapping.ColumnMappings.Add("idpostavshik", "idpostavshik");
            tableMapping.ColumnMappings.Add("idtovara", "idtovara");
            tableMapping.ColumnMappings.Add("idsotrudnika", "idsotrudnika");
            tableMapping.ColumnMappings.Add("nakladnaya", "nakladnaya");
            tableMapping.ColumnMappings.Add("kolichestvo", "kolichestvo");
            tableMapping.ColumnMappings.Add("datapolucheniya", "datapolucheniya");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM [Prihod] WHERE (([idprihod] = @p1))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p1", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idprihod", global::System.Data.DataRowVersion.Original, null));
            this._adapter.InsertCommand = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO [Prihod] ([idpostavshik], [idtovara], [idsotrudnika], [nakladnaya], [" +
                "kolichestvo], [datapolucheniya]) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p1", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idpostavshik", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p2", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idtovara", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p3", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idsotrudnika", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p4", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "nakladnaya", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p5", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "kolichestvo", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p6", global::System.Data.SqlDbType.DateTime, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "datapolucheniya", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = "UPDATE [Prihod] SET [idpostavshik] = @p1, [idtovara] = @p2, [idsotrudnika] = @p3," +
                " [nakladnaya] = @p4, [kolichestvo] = @p5, [datapolucheniya] = @p6 WHERE (([idpri" +
                "hod] = @p7))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p1", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idpostavshik", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p2", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idtovara", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p3", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idsotrudnika", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p4", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "nakladnaya", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p5", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "kolichestvo", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p6", global::System.Data.SqlDbType.DateTime, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "datapolucheniya", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p7", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idprihod", global::System.Data.DataRowVersion.Original, null));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitConnection()
        {
            this._connection = new global::System.Data.SqlServerCe.SqlCeConnection();
            this._connection.ConnectionString = global::SkladSUBD.Properties.Settings.Default.SkladConnectionString;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection()
        {
            this._commandCollection = new global::System.Data.SqlServerCe.SqlCeCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT [idprihod], [idpostavshik], [idtovara], [idsotrudnika], [nakladnaya], [kol" +
                "ichestvo], [datapolucheniya] FROM [Prihod]";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(SkladDataSet.PrihodDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true))
            {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual SkladDataSet.PrihodDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            SkladDataSet.PrihodDataTable dataTable = new SkladDataSet.PrihodDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(SkladDataSet.PrihodDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(SkladDataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "Prihod");
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow)
        {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int p1)
        {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(p1));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(int p1, int p2, int p3, string p4, global::System.Nullable<int> p5, global::System.Nullable<global::System.DateTime> p6)
        {
            this.Adapter.InsertCommand.Parameters[0].Value = ((int)(p1));
            this.Adapter.InsertCommand.Parameters[1].Value = ((int)(p2));
            this.Adapter.InsertCommand.Parameters[2].Value = ((int)(p3));
            if ((p4 == null))
            {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[3].Value = ((string)(p4));
            }
            if ((p5.HasValue == true))
            {
                this.Adapter.InsertCommand.Parameters[4].Value = ((int)(p5.Value));
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((p6.HasValue == true))
            {
                this.Adapter.InsertCommand.Parameters[5].Value = ((System.DateTime)(p6.Value));
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(int p1, int p2, int p3, string p4, global::System.Nullable<int> p5, global::System.Nullable<global::System.DateTime> p6, int p7)
        {
            this.Adapter.UpdateCommand.Parameters[0].Value = ((int)(p1));
            this.Adapter.UpdateCommand.Parameters[1].Value = ((int)(p2));
            this.Adapter.UpdateCommand.Parameters[2].Value = ((int)(p3));
            if ((p4 == null))
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((string)(p4));
            }
            if ((p5.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((int)(p5.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((p6.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((System.DateTime)(p6.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[6].Value = ((int)(p7));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
    }

    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class RashodTableAdapter : global::System.ComponentModel.Component
    {

        private global::System.Data.SqlServerCe.SqlCeDataAdapter _adapter;

        private global::System.Data.SqlServerCe.SqlCeConnection _connection;

        private global::System.Data.SqlServerCe.SqlCeTransaction _transaction;

        private global::System.Data.SqlServerCe.SqlCeCommand[] _commandCollection;

        private bool _clearBeforeFill;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public RashodTableAdapter()
        {
            this.ClearBeforeFill = true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected internal global::System.Data.SqlServerCe.SqlCeDataAdapter Adapter
        {
            get
            {
                if ((this._adapter == null))
                {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.SqlServerCe.SqlCeConnection Connection
        {
            get
            {
                if ((this._connection == null))
                {
                    this.InitConnection();
                }
                return this._connection;
            }
            set
            {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null))
                {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null))
                {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null))
                {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    if ((this.CommandCollection[i] != null))
                    {
                        ((global::System.Data.SqlServerCe.SqlCeCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.SqlServerCe.SqlCeTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
            set
            {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.DeleteCommand != null)))
                {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.InsertCommand != null)))
                {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.UpdateCommand != null)))
                {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected global::System.Data.SqlServerCe.SqlCeCommand[] CommandCollection
        {
            get
            {
                if ((this._commandCollection == null))
                {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool ClearBeforeFill
        {
            get
            {
                return this._clearBeforeFill;
            }
            set
            {
                this._clearBeforeFill = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter()
        {
            this._adapter = new global::System.Data.SqlServerCe.SqlCeDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Rashod";
            tableMapping.ColumnMappings.Add("idrashod", "idrashod");
            tableMapping.ColumnMappings.Add("idklienta", "idklienta");
            tableMapping.ColumnMappings.Add("idtovara", "idtovara");
            tableMapping.ColumnMappings.Add("idsotrudnika", "idsotrudnika");
            tableMapping.ColumnMappings.Add("nakladnaya", "nakladnaya");
            tableMapping.ColumnMappings.Add("kolichestvo", "kolichestvo");
            tableMapping.ColumnMappings.Add("datavidachi", "datavidachi");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM [Rashod] WHERE (([idrashod] = @p1))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p1", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idrashod", global::System.Data.DataRowVersion.Original, null));
            this._adapter.InsertCommand = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO [Rashod] ([idklienta], [idtovara], [idsotrudnika], [nakladnaya], [kol" +
                "ichestvo], [datavidachi]) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p1", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idklienta", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p2", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idtovara", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p3", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idsotrudnika", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p4", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "nakladnaya", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p5", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "kolichestvo", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p6", global::System.Data.SqlDbType.DateTime, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "datavidachi", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = "UPDATE [Rashod] SET [idklienta] = @p1, [idtovara] = @p2, [idsotrudnika] = @p3, [n" +
                "akladnaya] = @p4, [kolichestvo] = @p5, [datavidachi] = @p6 WHERE (([idrashod] = " +
                "@p7))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p1", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idklienta", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p2", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idtovara", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p3", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idsotrudnika", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p4", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "nakladnaya", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p5", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "kolichestvo", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p6", global::System.Data.SqlDbType.DateTime, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "datavidachi", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p7", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idrashod", global::System.Data.DataRowVersion.Original, null));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitConnection()
        {
            this._connection = new global::System.Data.SqlServerCe.SqlCeConnection();
            this._connection.ConnectionString = global::SkladSUBD.Properties.Settings.Default.SkladConnectionString;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection()
        {
            this._commandCollection = new global::System.Data.SqlServerCe.SqlCeCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT [idrashod], [idklienta], [idtovara], [idsotrudnika], [nakladnaya], [kolich" +
                "estvo], [datavidachi] FROM [Rashod]";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(SkladDataSet.RashodDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true))
            {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual SkladDataSet.RashodDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            SkladDataSet.RashodDataTable dataTable = new SkladDataSet.RashodDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(SkladDataSet.RashodDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(SkladDataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "Rashod");
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow)
        {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int p1)
        {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(p1));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(int p1, int p2, int p3, string p4, global::System.Nullable<int> p5, global::System.Nullable<global::System.DateTime> p6)
        {
            this.Adapter.InsertCommand.Parameters[0].Value = ((int)(p1));
            this.Adapter.InsertCommand.Parameters[1].Value = ((int)(p2));
            this.Adapter.InsertCommand.Parameters[2].Value = ((int)(p3));
            if ((p4 == null))
            {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[3].Value = ((string)(p4));
            }
            if ((p5.HasValue == true))
            {
                this.Adapter.InsertCommand.Parameters[4].Value = ((int)(p5.Value));
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((p6.HasValue == true))
            {
                this.Adapter.InsertCommand.Parameters[5].Value = ((System.DateTime)(p6.Value));
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(int p1, int p2, int p3, string p4, global::System.Nullable<int> p5, global::System.Nullable<global::System.DateTime> p6, int p7)
        {
            this.Adapter.UpdateCommand.Parameters[0].Value = ((int)(p1));
            this.Adapter.UpdateCommand.Parameters[1].Value = ((int)(p2));
            this.Adapter.UpdateCommand.Parameters[2].Value = ((int)(p3));
            if ((p4 == null))
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((string)(p4));
            }
            if ((p5.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((int)(p5.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((p6.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((System.DateTime)(p6.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[6].Value = ((int)(p7));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
    }

    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class SotrudnikiTableAdapter : global::System.ComponentModel.Component
    {

        private global::System.Data.SqlServerCe.SqlCeDataAdapter _adapter;

        private global::System.Data.SqlServerCe.SqlCeConnection _connection;

        private global::System.Data.SqlServerCe.SqlCeTransaction _transaction;

        private global::System.Data.SqlServerCe.SqlCeCommand[] _commandCollection;

        private bool _clearBeforeFill;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public SotrudnikiTableAdapter()
        {
            this.ClearBeforeFill = true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected internal global::System.Data.SqlServerCe.SqlCeDataAdapter Adapter
        {
            get
            {
                if ((this._adapter == null))
                {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.SqlServerCe.SqlCeConnection Connection
        {
            get
            {
                if ((this._connection == null))
                {
                    this.InitConnection();
                }
                return this._connection;
            }
            set
            {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null))
                {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null))
                {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null))
                {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    if ((this.CommandCollection[i] != null))
                    {
                        ((global::System.Data.SqlServerCe.SqlCeCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.SqlServerCe.SqlCeTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
            set
            {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.DeleteCommand != null)))
                {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.InsertCommand != null)))
                {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.UpdateCommand != null)))
                {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected global::System.Data.SqlServerCe.SqlCeCommand[] CommandCollection
        {
            get
            {
                if ((this._commandCollection == null))
                {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool ClearBeforeFill
        {
            get
            {
                return this._clearBeforeFill;
            }
            set
            {
                this._clearBeforeFill = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter()
        {
            this._adapter = new global::System.Data.SqlServerCe.SqlCeDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Sotrudniki";
            tableMapping.ColumnMappings.Add("idsotrudnika", "idsotrudnika");
            tableMapping.ColumnMappings.Add("fam", "fam");
            tableMapping.ColumnMappings.Add("name", "name");
            tableMapping.ColumnMappings.Add("otch", "otch");
            tableMapping.ColumnMappings.Add("bday", "bday");
            tableMapping.ColumnMappings.Add("dolzhnost", "dolzhnost");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM [Sotrudniki] WHERE (([idsotrudnika] = @p1))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p1", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idsotrudnika", global::System.Data.DataRowVersion.Original, null));
            this._adapter.InsertCommand = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO [Sotrudniki] ([fam], [name], [otch], [bday], [dolzhnost]) VALUES (@p1, @p2, @p3, @p4, @p5)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p1", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "fam", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p2", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "name", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p3", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "otch", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p4", global::System.Data.SqlDbType.DateTime, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "bday", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p5", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "dolzhnost", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = "UPDATE [Sotrudniki] SET [fam] = @p1, [name] = @p2, [otch] = @p3, [bday] = @p4, [d" +
                "olzhnost] = @p5 WHERE (([idsotrudnika] = @p8))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p1", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "fam", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p2", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "name", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p3", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "otch", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p4", global::System.Data.SqlDbType.DateTime, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "bday", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p5", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "dolzhnost", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p8", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idsotrudnika", global::System.Data.DataRowVersion.Original, null));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitConnection()
        {
            this._connection = new global::System.Data.SqlServerCe.SqlCeConnection();
            this._connection.ConnectionString = global::SkladSUBD.Properties.Settings.Default.SkladConnectionString;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection()
        {
            this._commandCollection = new global::System.Data.SqlServerCe.SqlCeCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT [idsotrudnika], [fam], [name], [otch], [bday], [dolzhnost] FROM [Sotrudniki]";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(SkladDataSet.SotrudnikiDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true))
            {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual SkladDataSet.SotrudnikiDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            SkladDataSet.SotrudnikiDataTable dataTable = new SkladDataSet.SotrudnikiDataTable(true);
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(SkladDataSet.SotrudnikiDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(SkladDataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "Sotrudniki");
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow)
        {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int p1)
        {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(p1));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string p1, string p2, string p3, global::System.Nullable<global::System.DateTime> p4, string p5)
        {
            if ((p1 == null))
            {
                this.Adapter.InsertCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(p1));
            }
            if ((p2 == null))
            {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(p2));
            }
            if ((p3 == null))
            {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[2].Value = ((string)(p3));
            }
            if ((p4.HasValue == true))
            {
                this.Adapter.InsertCommand.Parameters[3].Value = ((System.DateTime)(p4.Value));
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((p5 == null))
            {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[4].Value = ((string)(p5));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string p1, string p2, string p3, global::System.Nullable<global::System.DateTime> p4, string p5, string p6, byte[] p7, int p8)
        {
            if ((p1 == null))
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(p1));
            }
            if ((p2 == null))
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(p2));
            }
            if ((p3 == null))
            {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(p3));
            }
            if ((p4.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((System.DateTime)(p4.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((p5 == null))
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((string)(p5));
            }
            this.Adapter.UpdateCommand.Parameters[7].Value = ((int)(p8));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
    }

    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class TovariTableAdapter : global::System.ComponentModel.Component
    {

        private global::System.Data.SqlServerCe.SqlCeDataAdapter _adapter;

        private global::System.Data.SqlServerCe.SqlCeConnection _connection;

        private global::System.Data.SqlServerCe.SqlCeTransaction _transaction;

        private global::System.Data.SqlServerCe.SqlCeCommand[] _commandCollection;

        private bool _clearBeforeFill;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public TovariTableAdapter()
        {
            this.ClearBeforeFill = true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected internal global::System.Data.SqlServerCe.SqlCeDataAdapter Adapter
        {
            get
            {
                if ((this._adapter == null))
                {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.SqlServerCe.SqlCeConnection Connection
        {
            get
            {
                if ((this._connection == null))
                {
                    this.InitConnection();
                }
                return this._connection;
            }
            set
            {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null))
                {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null))
                {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null))
                {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    if ((this.CommandCollection[i] != null))
                    {
                        ((global::System.Data.SqlServerCe.SqlCeCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal global::System.Data.SqlServerCe.SqlCeTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
            set
            {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.DeleteCommand != null)))
                {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.InsertCommand != null)))
                {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null)
                            && (this.Adapter.UpdateCommand != null)))
                {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected global::System.Data.SqlServerCe.SqlCeCommand[] CommandCollection
        {
            get
            {
                if ((this._commandCollection == null))
                {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool ClearBeforeFill
        {
            get
            {
                return this._clearBeforeFill;
            }
            set
            {
                this._clearBeforeFill = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitAdapter()
        {
            this._adapter = new global::System.Data.SqlServerCe.SqlCeDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Tovari";
            tableMapping.ColumnMappings.Add("idtovara", "idtovara");
            tableMapping.ColumnMappings.Add("nametovara", "nametovara");
            tableMapping.ColumnMappings.Add("edizmer", "edizmer");
            tableMapping.ColumnMappings.Add("kolichestvo", "kolichestvo");
            tableMapping.ColumnMappings.Add("primechanie", "primechanie");
            tableMapping.ColumnMappings.Add("cena", "cena");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM [Tovari] WHERE (([idtovara] = @p1))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p1", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idtovara", global::System.Data.DataRowVersion.Original, null));
            this._adapter.InsertCommand = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO [Tovari] ([nametovara], [edizmer], [kolichestvo], [primechanie], [cen" +
                "a]) VALUES (@p1, @p2, @p3, @p4, @p5)";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p1", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "nametovara", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p2", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "edizmer", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p3", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "kolichestvo", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p4", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "primechanie", global::System.Data.DataRowVersion.Current, null));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p5", global::System.Data.SqlDbType.Money, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "cena", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = "UPDATE [Tovari] SET [nametovara] = @p1, [edizmer] = @p2, [kolichestvo] = @p3, [pr" +
                "imechanie] = @p4, [cena] = @p5 WHERE (([idtovara] = @p6))";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p1", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "nametovara", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p2", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "edizmer", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p3", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "kolichestvo", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p4", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "primechanie", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p5", global::System.Data.SqlDbType.Money, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "cena", global::System.Data.DataRowVersion.Current, null));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlServerCe.SqlCeParameter("@p6", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, true, 0, 0, "idtovara", global::System.Data.DataRowVersion.Original, null));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitConnection()
        {
            this._connection = new global::System.Data.SqlServerCe.SqlCeConnection();
            this._connection.ConnectionString = global::SkladSUBD.Properties.Settings.Default.SkladConnectionString;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection()
        {
            this._commandCollection = new global::System.Data.SqlServerCe.SqlCeCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlServerCe.SqlCeCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT [idtovara], [nametovara], [edizmer], [kolichestvo], [primechanie], [cena] " +
                "FROM [Tovari]";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(SkladDataSet.TovariDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true))
            {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual SkladDataSet.TovariDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            SkladDataSet.TovariDataTable dataTable = new SkladDataSet.TovariDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(SkladDataSet.TovariDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(SkladDataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "Tovari");
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow)
        {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int p1)
        {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(p1));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string p1, string p2, global::System.Nullable<int> p3, string p4, global::System.Nullable<decimal> p5)
        {
            if ((p1 == null))
            {
                this.Adapter.InsertCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(p1));
            }
            if ((p2 == null))
            {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(p2));
            }
            if ((p3.HasValue == true))
            {
                this.Adapter.InsertCommand.Parameters[2].Value = ((int)(p3.Value));
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((p4 == null))
            {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[3].Value = ((string)(p4));
            }
            if ((p5.HasValue == true))
            {
                this.Adapter.InsertCommand.Parameters[4].Value = ((decimal)(p5.Value));
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string p1, string p2, global::System.Nullable<int> p3, string p4, global::System.Nullable<decimal> p5, int p6)
        {
            if ((p1 == null))
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(p1));
            }
            if ((p2 == null))
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(p2));
            }
            if ((p3.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((int)(p3.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((p4 == null))
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((string)(p4));
            }
            if ((p5.HasValue == true))
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((decimal)(p5.Value));
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[5].Value = ((int)(p6));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try
            {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
    }

    /// <summary>
    ///TableAdapterManager is used to coordinate TableAdapters in the dataset to enable Hierarchical Update scenarios
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSD" +
        "esigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapterManager")]
    public partial class TableAdapterManager : global::System.ComponentModel.Component
    {

        private UpdateOrderOption _updateOrder;

        private KlientiTableAdapter _klientiTableAdapter;

        private PostavshikiTableAdapter _postavshikiTableAdapter;

        private PrihodTableAdapter _prihodTableAdapter;

        private RashodTableAdapter _rashodTableAdapter;

        private SotrudnikiTableAdapter _sotrudnikiTableAdapter;

        private TovariTableAdapter _tovariTableAdapter;

        private bool _backupDataSetBeforeUpdate;

        private global::System.Data.IDbConnection _connection;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public UpdateOrderOption UpdateOrder
        {
            get
            {
                return this._updateOrder;
            }
            set
            {
                this._updateOrder = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public KlientiTableAdapter KlientiTableAdapter
        {
            get
            {
                return this._klientiTableAdapter;
            }
            set
            {
                this._klientiTableAdapter = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public PostavshikiTableAdapter PostavshikiTableAdapter
        {
            get
            {
                return this._postavshikiTableAdapter;
            }
            set
            {
                this._postavshikiTableAdapter = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public PrihodTableAdapter PrihodTableAdapter
        {
            get
            {
                return this._prihodTableAdapter;
            }
            set
            {
                this._prihodTableAdapter = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public RashodTableAdapter RashodTableAdapter
        {
            get
            {
                return this._rashodTableAdapter;
            }
            set
            {
                this._rashodTableAdapter = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public SotrudnikiTableAdapter SotrudnikiTableAdapter
        {
            get
            {
                return this._sotrudnikiTableAdapter;
            }
            set
            {
                this._sotrudnikiTableAdapter = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public TovariTableAdapter TovariTableAdapter
        {
            get
            {
                return this._tovariTableAdapter;
            }
            set
            {
                this._tovariTableAdapter = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool BackupDataSetBeforeUpdate
        {
            get
            {
                return this._backupDataSetBeforeUpdate;
            }
            set
            {
                this._backupDataSetBeforeUpdate = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public global::System.Data.IDbConnection Connection
        {
            get
            {
                if ((this._connection != null))
                {
                    return this._connection;
                }
                if (((this._klientiTableAdapter != null)
                            && (this._klientiTableAdapter.Connection != null)))
                {
                    return this._klientiTableAdapter.Connection;
                }
                if (((this._postavshikiTableAdapter != null)
                            && (this._postavshikiTableAdapter.Connection != null)))
                {
                    return this._postavshikiTableAdapter.Connection;
                }
                if (((this._prihodTableAdapter != null)
                            && (this._prihodTableAdapter.Connection != null)))
                {
                    return this._prihodTableAdapter.Connection;
                }
                if (((this._rashodTableAdapter != null)
                            && (this._rashodTableAdapter.Connection != null)))
                {
                    return this._rashodTableAdapter.Connection;
                }
                if (((this._sotrudnikiTableAdapter != null)
                            && (this._sotrudnikiTableAdapter.Connection != null)))
                {
                    return this._sotrudnikiTableAdapter.Connection;
                }
                if (((this._tovariTableAdapter != null)
                            && (this._tovariTableAdapter.Connection != null)))
                {
                    return this._tovariTableAdapter.Connection;
                }
                return null;
            }
            set
            {
                this._connection = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public int TableAdapterInstanceCount
        {
            get
            {
                int count = 0;
                if ((this._klientiTableAdapter != null))
                {
                    count = (count + 1);
                }
                if ((this._postavshikiTableAdapter != null))
                {
                    count = (count + 1);
                }
                if ((this._prihodTableAdapter != null))
                {
                    count = (count + 1);
                }
                if ((this._rashodTableAdapter != null))
                {
                    count = (count + 1);
                }
                if ((this._sotrudnikiTableAdapter != null))
                {
                    count = (count + 1);
                }
                if ((this._tovariTableAdapter != null))
                {
                    count = (count + 1);
                }
                return count;
            }
        }

        /// <summary>
        ///Update rows in top-down order.
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private int UpdateUpdatedRows(SkladDataSet dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows)
        {
            int result = 0;
            if ((this._tovariTableAdapter != null))
            {
                global::System.Data.DataRow[] updatedRows = dataSet.Tovari.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null)
                            && (0 < updatedRows.Length)))
                {
                    result = (result + this._tovariTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._sotrudnikiTableAdapter != null))
            {
                global::System.Data.DataRow[] updatedRows = dataSet.Sotrudniki.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null)
                            && (0 < updatedRows.Length)))
                {
                    result = (result + this._sotrudnikiTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._klientiTableAdapter != null))
            {
                global::System.Data.DataRow[] updatedRows = dataSet.Klienti.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null)
                            && (0 < updatedRows.Length)))
                {
                    result = (result + this._klientiTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._postavshikiTableAdapter != null))
            {
                global::System.Data.DataRow[] updatedRows = dataSet.Postavshiki.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null)
                            && (0 < updatedRows.Length)))
                {
                    result = (result + this._postavshikiTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._prihodTableAdapter != null))
            {
                global::System.Data.DataRow[] updatedRows = dataSet.Prihod.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null)
                            && (0 < updatedRows.Length)))
                {
                    result = (result + this._prihodTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._rashodTableAdapter != null))
            {
                global::System.Data.DataRow[] updatedRows = dataSet.Rashod.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null)
                            && (0 < updatedRows.Length)))
                {
                    result = (result + this._rashodTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            return result;
        }

        /// <summary>
        ///Insert rows in top-down order.
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private int UpdateInsertedRows(SkladDataSet dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows)
        {
            int result = 0;
            if ((this._tovariTableAdapter != null))
            {
                global::System.Data.DataRow[] addedRows = dataSet.Tovari.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null)
                            && (0 < addedRows.Length)))
                {
                    result = (result + this._tovariTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._sotrudnikiTableAdapter != null))
            {
                global::System.Data.DataRow[] addedRows = dataSet.Sotrudniki.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null)
                            && (0 < addedRows.Length)))
                {
                    result = (result + this._sotrudnikiTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._klientiTableAdapter != null))
            {
                global::System.Data.DataRow[] addedRows = dataSet.Klienti.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null)
                            && (0 < addedRows.Length)))
                {
                    result = (result + this._klientiTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._postavshikiTableAdapter != null))
            {
                global::System.Data.DataRow[] addedRows = dataSet.Postavshiki.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null)
                            && (0 < addedRows.Length)))
                {
                    result = (result + this._postavshikiTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._prihodTableAdapter != null))
            {
                global::System.Data.DataRow[] addedRows = dataSet.Prihod.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null)
                            && (0 < addedRows.Length)))
                {
                    result = (result + this._prihodTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._rashodTableAdapter != null))
            {
                global::System.Data.DataRow[] addedRows = dataSet.Rashod.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null)
                            && (0 < addedRows.Length)))
                {
                    result = (result + this._rashodTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            return result;
        }

        /// <summary>
        ///Delete rows in bottom-up order.
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private int UpdateDeletedRows(SkladDataSet dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows)
        {
            int result = 0;
            if ((this._rashodTableAdapter != null))
            {
                global::System.Data.DataRow[] deletedRows = dataSet.Rashod.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null)
                            && (0 < deletedRows.Length)))
                {
                    result = (result + this._rashodTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._prihodTableAdapter != null))
            {
                global::System.Data.DataRow[] deletedRows = dataSet.Prihod.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null)
                            && (0 < deletedRows.Length)))
                {
                    result = (result + this._prihodTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._postavshikiTableAdapter != null))
            {
                global::System.Data.DataRow[] deletedRows = dataSet.Postavshiki.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null)
                            && (0 < deletedRows.Length)))
                {
                    result = (result + this._postavshikiTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._klientiTableAdapter != null))
            {
                global::System.Data.DataRow[] deletedRows = dataSet.Klienti.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null)
                            && (0 < deletedRows.Length)))
                {
                    result = (result + this._klientiTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._sotrudnikiTableAdapter != null))
            {
                global::System.Data.DataRow[] deletedRows = dataSet.Sotrudniki.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null)
                            && (0 < deletedRows.Length)))
                {
                    result = (result + this._sotrudnikiTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._tovariTableAdapter != null))
            {
                global::System.Data.DataRow[] deletedRows = dataSet.Tovari.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null)
                            && (0 < deletedRows.Length)))
                {
                    result = (result + this._tovariTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            return result;
        }

        /// <summary>
        ///Remove inserted rows that become updated rows after calling TableAdapter.Update(inserted rows) first
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private global::System.Data.DataRow[] GetRealUpdatedRows(global::System.Data.DataRow[] updatedRows, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows)
        {
            if (((updatedRows == null)
                        || (updatedRows.Length < 1)))
            {
                return updatedRows;
            }
            if (((allAddedRows == null)
                        || (allAddedRows.Count < 1)))
            {
                return updatedRows;
            }
            global::System.Collections.Generic.List<global::System.Data.DataRow> realUpdatedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            for (int i = 0; (i < updatedRows.Length); i = (i + 1))
            {
                global::System.Data.DataRow row = updatedRows[i];
                if ((allAddedRows.Contains(row) == false))
                {
                    realUpdatedRows.Add(row);
                }
            }
            return realUpdatedRows.ToArray();
        }

        /// <summary>
        ///Update all changes to the dataset.
        ///</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int UpdateAll(SkladDataSet dataSet)
        {
            if ((dataSet == null))
            {
                throw new global::System.ArgumentNullException("dataSet");
            }
            if ((dataSet.HasChanges() == false))
            {
                return 0;
            }
            if (((this._klientiTableAdapter != null)
                        && (this.MatchTableAdapterConnection(this._klientiTableAdapter.Connection) == false)))
            {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._postavshikiTableAdapter != null)
                        && (this.MatchTableAdapterConnection(this._postavshikiTableAdapter.Connection) == false)))
            {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._prihodTableAdapter != null)
                        && (this.MatchTableAdapterConnection(this._prihodTableAdapter.Connection) == false)))
            {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._rashodTableAdapter != null)
                        && (this.MatchTableAdapterConnection(this._rashodTableAdapter.Connection) == false)))
            {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._sotrudnikiTableAdapter != null)
                        && (this.MatchTableAdapterConnection(this._sotrudnikiTableAdapter.Connection) == false)))
            {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._tovariTableAdapter != null)
                        && (this.MatchTableAdapterConnection(this._tovariTableAdapter.Connection) == false)))
            {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            global::System.Data.IDbConnection workConnection = this.Connection;
            if ((workConnection == null))
            {
                throw new global::System.ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterMana" +
                        "ger TableAdapter property to a valid TableAdapter instance.");
            }
            bool workConnOpened = false;
            if (((workConnection.State & global::System.Data.ConnectionState.Broken)
                        == global::System.Data.ConnectionState.Broken))
            {
                workConnection.Close();
            }
            if ((workConnection.State == global::System.Data.ConnectionState.Closed))
            {
                workConnection.Open();
                workConnOpened = true;
            }
            global::System.Data.IDbTransaction workTransaction = workConnection.BeginTransaction();
            if ((workTransaction == null))
            {
                throw new global::System.ApplicationException("The transaction cannot begin. The current data connection does not support transa" +
                        "ctions or the current state is not allowing the transaction to begin.");
            }
            global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            global::System.Collections.Generic.List<global::System.Data.Common.DataAdapter> adaptersWithAcceptChangesDuringUpdate = new global::System.Collections.Generic.List<global::System.Data.Common.DataAdapter>();
            global::System.Collections.Generic.Dictionary<object, global::System.Data.IDbConnection> revertConnections = new global::System.Collections.Generic.Dictionary<object, global::System.Data.IDbConnection>();
            int result = 0;
            global::System.Data.DataSet backupDataSet = null;
            if (this.BackupDataSetBeforeUpdate)
            {
                backupDataSet = new global::System.Data.DataSet();
                backupDataSet.Merge(dataSet);
            }
            try
            {
                // ---- Prepare for update -----------
                //
                if ((this._klientiTableAdapter != null))
                {
                    revertConnections.Add(this._klientiTableAdapter, this._klientiTableAdapter.Connection);
                    this._klientiTableAdapter.Connection = ((global::System.Data.SqlServerCe.SqlCeConnection)(workConnection));
                    this._klientiTableAdapter.Transaction = ((global::System.Data.SqlServerCe.SqlCeTransaction)(workTransaction));
                    if (this._klientiTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._klientiTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._klientiTableAdapter.Adapter);
                    }
                }
                if ((this._postavshikiTableAdapter != null))
                {
                    revertConnections.Add(this._postavshikiTableAdapter, this._postavshikiTableAdapter.Connection);
                    this._postavshikiTableAdapter.Connection = ((global::System.Data.SqlServerCe.SqlCeConnection)(workConnection));
                    this._postavshikiTableAdapter.Transaction = ((global::System.Data.SqlServerCe.SqlCeTransaction)(workTransaction));
                    if (this._postavshikiTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._postavshikiTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._postavshikiTableAdapter.Adapter);
                    }
                }
                if ((this._prihodTableAdapter != null))
                {
                    revertConnections.Add(this._prihodTableAdapter, this._prihodTableAdapter.Connection);
                    this._prihodTableAdapter.Connection = ((global::System.Data.SqlServerCe.SqlCeConnection)(workConnection));
                    this._prihodTableAdapter.Transaction = ((global::System.Data.SqlServerCe.SqlCeTransaction)(workTransaction));
                    if (this._prihodTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._prihodTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._prihodTableAdapter.Adapter);
                    }
                }
                if ((this._rashodTableAdapter != null))
                {
                    revertConnections.Add(this._rashodTableAdapter, this._rashodTableAdapter.Connection);
                    this._rashodTableAdapter.Connection = ((global::System.Data.SqlServerCe.SqlCeConnection)(workConnection));
                    this._rashodTableAdapter.Transaction = ((global::System.Data.SqlServerCe.SqlCeTransaction)(workTransaction));
                    if (this._rashodTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._rashodTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._rashodTableAdapter.Adapter);
                    }
                }
                if ((this._sotrudnikiTableAdapter != null))
                {
                    revertConnections.Add(this._sotrudnikiTableAdapter, this._sotrudnikiTableAdapter.Connection);
                    this._sotrudnikiTableAdapter.Connection = ((global::System.Data.SqlServerCe.SqlCeConnection)(workConnection));
                    this._sotrudnikiTableAdapter.Transaction = ((global::System.Data.SqlServerCe.SqlCeTransaction)(workTransaction));
                    if (this._sotrudnikiTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._sotrudnikiTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._sotrudnikiTableAdapter.Adapter);
                    }
                }
                if ((this._tovariTableAdapter != null))
                {
                    revertConnections.Add(this._tovariTableAdapter, this._tovariTableAdapter.Connection);
                    this._tovariTableAdapter.Connection = ((global::System.Data.SqlServerCe.SqlCeConnection)(workConnection));
                    this._tovariTableAdapter.Transaction = ((global::System.Data.SqlServerCe.SqlCeTransaction)(workTransaction));
                    if (this._tovariTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        this._tovariTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._tovariTableAdapter.Adapter);
                    }
                }
                // 
                //---- Perform updates -----------
                //
                if ((this.UpdateOrder == UpdateOrderOption.UpdateInsertDelete))
                {
                    result = (result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
                    result = (result + this.UpdateInsertedRows(dataSet, allAddedRows));
                }
                else
                {
                    result = (result + this.UpdateInsertedRows(dataSet, allAddedRows));
                    result = (result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
                }
                result = (result + this.UpdateDeletedRows(dataSet, allChangedRows));
                // 
                //---- Commit updates -----------
                //
                workTransaction.Commit();
                if ((0 < allAddedRows.Count))
                {
                    global::System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                    allAddedRows.CopyTo(rows);
                    for (int i = 0; (i < rows.Length); i = (i + 1))
                    {
                        global::System.Data.DataRow row = rows[i];
                        row.AcceptChanges();
                    }
                }
                if ((0 < allChangedRows.Count))
                {
                    global::System.Data.DataRow[] rows = new System.Data.DataRow[allChangedRows.Count];
                    allChangedRows.CopyTo(rows);
                    for (int i = 0; (i < rows.Length); i = (i + 1))
                    {
                        global::System.Data.DataRow row = rows[i];
                        row.AcceptChanges();
                    }
                }
            }
            catch (global::System.Exception ex)
            {
                workTransaction.Rollback();
                // ---- Restore the dataset -----------
                if (this.BackupDataSetBeforeUpdate)
                {
                    global::System.Diagnostics.Debug.Assert((backupDataSet != null));
                    dataSet.Clear();
                    dataSet.Merge(backupDataSet);
                }
                else
                {
                    if ((0 < allAddedRows.Count))
                    {
                        global::System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                        allAddedRows.CopyTo(rows);
                        for (int i = 0; (i < rows.Length); i = (i + 1))
                        {
                            global::System.Data.DataRow row = rows[i];
                            row.AcceptChanges();
                            row.SetAdded();
                        }
                    }
                }
                throw ex;
            }
            finally
            {
                if (workConnOpened)
                {
                    workConnection.Close();
                }
                if ((this._klientiTableAdapter != null))
                {
                    this._klientiTableAdapter.Connection = ((global::System.Data.SqlServerCe.SqlCeConnection)(revertConnections[this._klientiTableAdapter]));
                    this._klientiTableAdapter.Transaction = null;
                }
                if ((this._postavshikiTableAdapter != null))
                {
                    this._postavshikiTableAdapter.Connection = ((global::System.Data.SqlServerCe.SqlCeConnection)(revertConnections[this._postavshikiTableAdapter]));
                    this._postavshikiTableAdapter.Transaction = null;
                }
                if ((this._prihodTableAdapter != null))
                {
                    this._prihodTableAdapter.Connection = ((global::System.Data.SqlServerCe.SqlCeConnection)(revertConnections[this._prihodTableAdapter]));
                    this._prihodTableAdapter.Transaction = null;
                }
                if ((this._rashodTableAdapter != null))
                {
                    this._rashodTableAdapter.Connection = ((global::System.Data.SqlServerCe.SqlCeConnection)(revertConnections[this._rashodTableAdapter]));
                    this._rashodTableAdapter.Transaction = null;
                }
                if ((this._sotrudnikiTableAdapter != null))
                {
                    this._sotrudnikiTableAdapter.Connection = ((global::System.Data.SqlServerCe.SqlCeConnection)(revertConnections[this._sotrudnikiTableAdapter]));
                    this._sotrudnikiTableAdapter.Transaction = null;
                }
                if ((this._tovariTableAdapter != null))
                {
                    this._tovariTableAdapter.Connection = ((global::System.Data.SqlServerCe.SqlCeConnection)(revertConnections[this._tovariTableAdapter]));
                    this._tovariTableAdapter.Transaction = null;
                }
                if ((0 < adaptersWithAcceptChangesDuringUpdate.Count))
                {
                    global::System.Data.Common.DataAdapter[] adapters = new System.Data.Common.DataAdapter[adaptersWithAcceptChangesDuringUpdate.Count];
                    adaptersWithAcceptChangesDuringUpdate.CopyTo(adapters);
                    for (int i = 0; (i < adapters.Length); i = (i + 1))
                    {
                        global::System.Data.Common.DataAdapter adapter = adapters[i];
                        adapter.AcceptChangesDuringUpdate = true;
                    }
                }
            }
            return result;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected virtual void SortSelfReferenceRows(global::System.Data.DataRow[] rows, global::System.Data.DataRelation relation, bool childFirst)
        {
            global::System.Array.Sort<global::System.Data.DataRow>(rows, new SelfReferenceComparer(relation, childFirst));
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected virtual bool MatchTableAdapterConnection(global::System.Data.IDbConnection inputConnection)
        {
            if ((this._connection != null))
            {
                return true;
            }
            if (((this.Connection == null)
                        || (inputConnection == null)))
            {
                return true;
            }
            if (string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, global::System.StringComparison.Ordinal))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        ///Update Order Option
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public enum UpdateOrderOption
        {

            InsertUpdateDelete = 0,

            UpdateInsertDelete = 1,
        }

        /// <summary>
        ///Used to sort self-referenced table's rows
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private class SelfReferenceComparer : object, global::System.Collections.Generic.IComparer<global::System.Data.DataRow>
        {

            private global::System.Data.DataRelation _relation;

            private int _childFirst;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal SelfReferenceComparer(global::System.Data.DataRelation relation, bool childFirst)
            {
                this._relation = relation;
                if (childFirst)
                {
                    this._childFirst = -1;
                }
                else
                {
                    this._childFirst = 1;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private global::System.Data.DataRow GetRoot(global::System.Data.DataRow row, out int distance)
            {
                global::System.Diagnostics.Debug.Assert((row != null));
                global::System.Data.DataRow root = row;
                distance = 0;

                global::System.Collections.Generic.IDictionary<global::System.Data.DataRow, global::System.Data.DataRow> traversedRows = new global::System.Collections.Generic.Dictionary<global::System.Data.DataRow, global::System.Data.DataRow>();
                traversedRows[row] = row;

                global::System.Data.DataRow parent = row.GetParentRow(this._relation, global::System.Data.DataRowVersion.Default);
                for (
                ; ((parent != null)
                            && (traversedRows.ContainsKey(parent) == false));
                )
                {
                    distance = (distance + 1);
                    root = parent;
                    traversedRows[parent] = parent;
                    parent = parent.GetParentRow(this._relation, global::System.Data.DataRowVersion.Default);
                }

                if ((distance == 0))
                {
                    traversedRows.Clear();
                    traversedRows[row] = row;
                    parent = row.GetParentRow(this._relation, global::System.Data.DataRowVersion.Original);
                    for (
                    ; ((parent != null)
                                && (traversedRows.ContainsKey(parent) == false));
                    )
                    {
                        distance = (distance + 1);
                        root = parent;
                        traversedRows[parent] = parent;
                        parent = parent.GetParentRow(this._relation, global::System.Data.DataRowVersion.Original);
                    }
                }

                return root;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Compare(global::System.Data.DataRow row1, global::System.Data.DataRow row2)
            {
                if (object.ReferenceEquals(row1, row2))
                {
                    return 0;
                }
                if ((row1 == null))
                {
                    return -1;
                }
                if ((row2 == null))
                {
                    return 1;
                }

                int distance1 = 0;
                global::System.Data.DataRow root1 = this.GetRoot(row1, out distance1);

                int distance2 = 0;
                global::System.Data.DataRow root2 = this.GetRoot(row2, out distance2);

                if (object.ReferenceEquals(root1, root2))
                {
                    return (this._childFirst * distance1.CompareTo(distance2));
                }
                else
                {
                    global::System.Diagnostics.Debug.Assert(((root1.Table != null)
                                    && (root2.Table != null)));
                    if ((root1.Table.Rows.IndexOf(root1) < root2.Table.Rows.IndexOf(root2)))
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

#pragma warning restore 1591