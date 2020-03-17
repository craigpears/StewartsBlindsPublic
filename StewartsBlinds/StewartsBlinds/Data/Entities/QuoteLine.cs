using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StewartsBlinds.Data.Entities
{
    public class QuoteLine
    {
        public int Id { get; set; }
        public ProductType ProductType { get; set; }
        public int AppointmentId { get; set; }
        public String RoomRef { get; set; }
        public String Width { get; set; }
        public String Drop { get; set; }
        public String InstallationHeight { get; set; }
        public String SizeType { get; set; }
        public String HeadrailType { get; set; }
        public String ControlType { get; set; }
        public String ControlSide { get; set; }
        public String Stacking { get; set; }
        public String Brackets { get; set; }
        public String WeightsChain { get; set; }
        public String Fabric { get; set; }
        public int NumberOfSlats { get; set; }
        public bool SampleRetained { get; set; }
        public String System { get; set; }
        public String Controls { get; set; }
        public String Lining { get; set; }
        public String BeadDepth { get; set; }
        public String Profile { get; set; }
        public String Hardware { get; set; }
        public String Tape { get; set; }
        public String SlatSize { get; set; }
        public String FittingBrackets { get; set; }
        public String Control { get; set; }
        public String SlatColour { get; set; }
        public String Draw { get; set; }
        public String UnderGuarantee { get; set; }
        public String Description { get; set; }
        public String TrackColour { get; set; }
        public String TrackWidth { get; set; }
        public String TracksRequired { get; set; }
        public String Finial { get; set; }
        public String PoleColour { get; set; }
        public String PoleSize { get; set; }
        public String WindowType { get; set; }
        public String WindowSizeRef { get; set; }
        public String HooksRequired { get; set; }
        public String RingsRequired { get; set; }
        public String Slatting { get; set; }
        public String Braid { get; set; }
        public String Endcaps { get; set; }
        public String Scallop { get; set; }
        public String HoldDownBrackets { get; set; }
    }
}
