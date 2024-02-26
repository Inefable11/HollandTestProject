using System;
using System.Collections.Generic;
using System.Text;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandDetailsChart
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public int? scoreR { get; set; }
        public int? scoreI { get; set; }
        public int? scoreA { get; set; }
        public int? scoreS { get; set; }
        public int? scoreE { get; set; }
        public int? scoreC { get; set; }
        public double timeElapsed { get; set; }
        public string personality { get; set; }
        public string personalityDescription { get; set; }
        public string personalityVocations { get; set; }
    }
}
