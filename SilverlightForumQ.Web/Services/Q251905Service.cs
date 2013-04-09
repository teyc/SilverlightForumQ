
namespace SilverlightForumQ.Web.Services
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;
    using System.Runtime.Serialization;

    // TODO: Create methods containing your application logic.
    [EnableClientAccess()]
    public class Q251905Service : DomainService
    {
        [Query]
        public IQueryable<FormatModel> GetFormatModels()
        {
            return (new FormatModel[] {
                new FormatModel() { formatGuid = new Guid("aea7cf8d-d293-426e-8208-e1cb27e35a3c")},
            }).AsQueryable();
        }

        [Query]
        public IQueryable<FormatFieldModel> GetFormatFieldModels()
        {
            return (new FormatFieldModel[] {
                new FormatFieldModel() { formatGuid = new Guid("aea7cf8d-d293-426e-8208-e1cb27e35a3c"), fieldGuid = new Guid("aea7cf8d-d293-426e-8208-e1cb27e00001")},
                new FormatFieldModel() { formatGuid = new Guid("aea7cf8d-d293-426e-8208-e1cb27e35a3c"), fieldGuid = new Guid("aea7cf8d-d293-426e-8208-e1cb27e00002")},
                new FormatFieldModel() { formatGuid = new Guid("aea7cf8d-d293-426e-8208-e1cb27e35a3c"), fieldGuid = new Guid("aea7cf8d-d293-426e-8208-e1cb27e00003")},
                new FormatFieldModel() { formatGuid = new Guid("aea7cf8d-d293-426e-8208-e1cb27e35a3c"), fieldGuid = new Guid("aea7cf8d-d293-426e-8208-e1cb27e00004")},
            }).AsQueryable();
        }

    }


    [Serializable(), DataContract()]
    public class FormatModel
    {

        //[DataMember(), Key(), Association("FK_Format_FormatField", "formatGuid", "formatGuid")]
        //public Guid formatGuid { get; set; }

        [DataMember(), Key()]
        public Guid formatGuid { get; set; }

        [DataMember(), Association("FK_Format_FormatField", "formatGuid", "formatGuid")]
        public IEnumerable<FormatFieldModel> Fields { get; set; }

    }

    [Serializable(),DataContract()]
    public class FormatFieldModel
    {
        [DataMember(), Key()]
        public Guid fieldGuid { get; set; }

        [DataMember()]
        public Guid formatGuid { get; set; }//FK back to FormatModel class

        //[DataMember(), Association("FK_Format_FormatField", "formatGuid", "formatGuid", IsForeignKey = true)]
        //public Guid formatGuid { get; set; }//FK back to FormatModel class

        [DataMember(), Association("FK_Format_FormatField", "formatGuid", "formatGuid", IsForeignKey = true)]
        public FormatModel Model { get; set; }
    }

}


