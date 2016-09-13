using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeadsManager.Models
{
    //dbo.tblSync is the name of the database in CRMDATA/tlMain
    [Table("tblSync")]
    public class Talisma
    {
        private byte _deliveryStatus = 0;
        private int _aliasId = 4;
        private short? _mailType = 64;
        private string _msgContent = "";//XML goes here
        private string _from = null;
        private string _to = null;
        private string _cc = null;
        private string _bcc = null;
        private string _subject = "Talisma Code";
        private int? _eventId = -1;
        private bool _hasAttachment = false;
        private int? _languageId = null;

        public Talisma()
        {
            nDeliveryStatus = _deliveryStatus;
            nAliasID = _aliasId;
            nMailType = _mailType;
            mMsgContent = _msgContent;
            tFrom = _from;
            tTo = _to;
            tCc = _cc;
            tBcc = _bcc;
            tSubject = _subject;
            nEventID = _eventId;
            bHasAttachment = _hasAttachment;
            nLanguageID = _languageId;
        }

        [Key]
        public int aSyncMailID { get; set; }
        public byte nDeliveryStatus { get; set; }
        public int nAliasID { get; set; }
        public int? nTeamID { get; set; }
        public short? nMailType { get; set; }

        [Column(TypeName = "ntext")]
        public string mMsgContent { get; set; }

        [StringLength(500)]
        public string tFrom { get; set; }

        [StringLength(4000)]
        public string tTo { get; set; }

        [StringLength(4000)]
        public string tCc { get; set; }

        [StringLength(4000)]
        public string tBcc { get; set; }

        [StringLength(500)]
        public string tSubject { get; set; }
        public int? nEventID { get; set; }
        public bool bHasAttachment { get; set; }
        public int? nLanguageID { get; set; }
    }
}
