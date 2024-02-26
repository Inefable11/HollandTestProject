using System;
using System.Collections.Generic;
using System.Text;

namespace ApiModel._ResponseDTO.testH
{
    public class testDetailResponse
    {
        public string name { get; set; }
        public string img { get; set; }
        public double timeElapsed { get; set; }
        public string personality { get; set; }
        public string personalityVocations { get; set; }
        public DateTime fechaResolucion { get; set; }
        public int testId { get; set; }
    }
}
