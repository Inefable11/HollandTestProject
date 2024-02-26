using System;
using System.Collections.Generic;
using System.Text;
using ApiModel.testH;

namespace ApiModel._ResponseDTO.testH
{
    public class testHollandDetailsResponseDTO
    {
        public int id { get; set; }
        public int? idtestHolland { get; set; }
        public int? scoreR { get; set; }
        public int? scoreI { get; set; }
        public int? scoreA { get; set; }
        public int? scoreS { get; set; }
        public int? scoreE { get; set; }
        public int? scoreC { get; set; }
        public double? timeElapsed { get; set; }
        public string personality { get; set; }
        public string personalityDescription { get; set; }
        public string personalityVocations { get; set; }


        public testHollandDetailsResponseDTO Mapper(testHollandDetailsResponseDTO dto, testHollandDetails obj)
        {
            dto.id = obj.id;
            dto.idtestHolland = obj.idtestHolland;
            dto.scoreR = obj.scoreR;
            dto.scoreI = obj.scoreI;
            dto.scoreA = obj.scoreA;
            dto.scoreS = obj.scoreS;
            dto.scoreE = obj.scoreE;
            dto.scoreC = obj.scoreC;
            dto.timeElapsed = obj.timeElapsed;
            dto.personality = obj.personality;
            dto.personalityDescription = obj.personalityDescription;
            dto.personalityVocations = obj.personalityVocations;
            return dto;
        }
    }
}
