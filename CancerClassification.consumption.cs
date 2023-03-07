﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace MachineLearning
{
    public partial class CancerClassification
    {
        /// <summary>
        /// model input class for CancerClassification.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"Gene Description")]
            public string Gene_Description { get; set; }

            [ColumnName(@"Gene Accession Number")]
            public string Gene_Accession_Number { get; set; }

            [ColumnName(@"1")]
            public float _1 { get; set; }

            [ColumnName(@"call")]
            public string Call { get; set; }

            [ColumnName(@"2")]
            public float _2 { get; set; }

            [ColumnName(@"call2")]
            public string Call2 { get; set; }

            [ColumnName(@"3")]
            public float _3 { get; set; }

            [ColumnName(@"call3")]
            public string Call3 { get; set; }

            [ColumnName(@"4")]
            public float _4 { get; set; }

            [ColumnName(@"call4")]
            public string Call4 { get; set; }

            [ColumnName(@"5")]
            public float _5 { get; set; }

            [ColumnName(@"call5")]
            public string Call5 { get; set; }

            [ColumnName(@"6")]
            public float _6 { get; set; }

            [ColumnName(@"call6")]
            public string Call6 { get; set; }

            [ColumnName(@"7")]
            public float _7 { get; set; }

            [ColumnName(@"call7")]
            public string Call7 { get; set; }

            [ColumnName(@"8")]
            public float _8 { get; set; }

            [ColumnName(@"call8")]
            public string Call8 { get; set; }

            [ColumnName(@"9")]
            public float _9 { get; set; }

            [ColumnName(@"call9")]
            public string Call9 { get; set; }

            [ColumnName(@"10")]
            public float _10 { get; set; }

            [ColumnName(@"call10")]
            public string Call10 { get; set; }

            [ColumnName(@"11")]
            public float _11 { get; set; }

            [ColumnName(@"call11")]
            public string Call11 { get; set; }

            [ColumnName(@"12")]
            public float _12 { get; set; }

            [ColumnName(@"call12")]
            public string Call12 { get; set; }

            [ColumnName(@"13")]
            public float _13 { get; set; }

            [ColumnName(@"call13")]
            public string Call13 { get; set; }

            [ColumnName(@"14")]
            public float _14 { get; set; }

            [ColumnName(@"call14")]
            public string Call14 { get; set; }

            [ColumnName(@"15")]
            public float _15 { get; set; }

            [ColumnName(@"call15")]
            public string Call15 { get; set; }

            [ColumnName(@"16")]
            public float _16 { get; set; }

            [ColumnName(@"call16")]
            public string Call16 { get; set; }

            [ColumnName(@"17")]
            public float _17 { get; set; }

            [ColumnName(@"call17")]
            public string Call17 { get; set; }

            [ColumnName(@"18")]
            public float _18 { get; set; }

            [ColumnName(@"call18")]
            public string Call18 { get; set; }

            [ColumnName(@"19")]
            public float _19 { get; set; }

            [ColumnName(@"call19")]
            public string Call19 { get; set; }

            [ColumnName(@"20")]
            public float _20 { get; set; }

            [ColumnName(@"call20")]
            public string Call20 { get; set; }

            [ColumnName(@"21")]
            public float _21 { get; set; }

            [ColumnName(@"call21")]
            public string Call21 { get; set; }

            [ColumnName(@"22")]
            public float _22 { get; set; }

            [ColumnName(@"call22")]
            public string Call22 { get; set; }

            [ColumnName(@"23")]
            public float _23 { get; set; }

            [ColumnName(@"call23")]
            public string Call23 { get; set; }

            [ColumnName(@"24")]
            public float _24 { get; set; }

            [ColumnName(@"call24")]
            public string Call24 { get; set; }

            [ColumnName(@"25")]
            public float _25 { get; set; }

            [ColumnName(@"call25")]
            public string Call25 { get; set; }

            [ColumnName(@"26")]
            public float _26 { get; set; }

            [ColumnName(@"call26")]
            public string Call26 { get; set; }

            [ColumnName(@"27")]
            public float _27 { get; set; }

            [ColumnName(@"call27")]
            public string Call27 { get; set; }

            [ColumnName(@"34")]
            public float _34 { get; set; }

            [ColumnName(@"call28")]
            public string Call28 { get; set; }

            [ColumnName(@"35")]
            public float _35 { get; set; }

            [ColumnName(@"call29")]
            public string Call29 { get; set; }

            [ColumnName(@"36")]
            public float _36 { get; set; }

            [ColumnName(@"call30")]
            public string Call30 { get; set; }

            [ColumnName(@"37")]
            public float _37 { get; set; }

            [ColumnName(@"call31")]
            public string Call31 { get; set; }

            [ColumnName(@"38")]
            public float _38 { get; set; }

            [ColumnName(@"call32")]
            public string Call32 { get; set; }

            [ColumnName(@"28")]
            public float _28 { get; set; }

            [ColumnName(@"call33")]
            public string Call33 { get; set; }

            [ColumnName(@"29")]
            public float _29 { get; set; }

            [ColumnName(@"call34")]
            public string Call34 { get; set; }

            [ColumnName(@"30")]
            public float _30 { get; set; }

            [ColumnName(@"call35")]
            public string Call35 { get; set; }

            [ColumnName(@"31")]
            public float _31 { get; set; }

            [ColumnName(@"call36")]
            public string Call36 { get; set; }

            [ColumnName(@"32")]
            public float _32 { get; set; }

            [ColumnName(@"call37")]
            public string Call37 { get; set; }

            [ColumnName(@"33")]
            public float _33 { get; set; }

            [ColumnName(@"call38")]
            public string Call38 { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for CancerClassification.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"Gene Description")]
            public uint Gene_Description { get; set; }

            [ColumnName(@"Gene Accession Number")]
            public float[] Gene_Accession_Number { get; set; }

            [ColumnName(@"1")]
            public float _1 { get; set; }

            [ColumnName(@"call")]
            public float[] Call { get; set; }

            [ColumnName(@"2")]
            public float _2 { get; set; }

            [ColumnName(@"call2")]
            public float[] Call2 { get; set; }

            [ColumnName(@"3")]
            public float _3 { get; set; }

            [ColumnName(@"call3")]
            public float[] Call3 { get; set; }

            [ColumnName(@"4")]
            public float _4 { get; set; }

            [ColumnName(@"call4")]
            public float[] Call4 { get; set; }

            [ColumnName(@"5")]
            public float _5 { get; set; }

            [ColumnName(@"call5")]
            public float[] Call5 { get; set; }

            [ColumnName(@"6")]
            public float _6 { get; set; }

            [ColumnName(@"call6")]
            public float[] Call6 { get; set; }

            [ColumnName(@"7")]
            public float _7 { get; set; }

            [ColumnName(@"call7")]
            public float[] Call7 { get; set; }

            [ColumnName(@"8")]
            public float _8 { get; set; }

            [ColumnName(@"call8")]
            public float[] Call8 { get; set; }

            [ColumnName(@"9")]
            public float _9 { get; set; }

            [ColumnName(@"call9")]
            public float[] Call9 { get; set; }

            [ColumnName(@"10")]
            public float _10 { get; set; }

            [ColumnName(@"call10")]
            public float[] Call10 { get; set; }

            [ColumnName(@"11")]
            public float _11 { get; set; }

            [ColumnName(@"call11")]
            public float[] Call11 { get; set; }

            [ColumnName(@"12")]
            public float _12 { get; set; }

            [ColumnName(@"call12")]
            public float[] Call12 { get; set; }

            [ColumnName(@"13")]
            public float _13 { get; set; }

            [ColumnName(@"call13")]
            public float[] Call13 { get; set; }

            [ColumnName(@"14")]
            public float _14 { get; set; }

            [ColumnName(@"call14")]
            public float[] Call14 { get; set; }

            [ColumnName(@"15")]
            public float _15 { get; set; }

            [ColumnName(@"call15")]
            public float[] Call15 { get; set; }

            [ColumnName(@"16")]
            public float _16 { get; set; }

            [ColumnName(@"call16")]
            public float[] Call16 { get; set; }

            [ColumnName(@"17")]
            public float _17 { get; set; }

            [ColumnName(@"call17")]
            public float[] Call17 { get; set; }

            [ColumnName(@"18")]
            public float _18 { get; set; }

            [ColumnName(@"call18")]
            public float[] Call18 { get; set; }

            [ColumnName(@"19")]
            public float _19 { get; set; }

            [ColumnName(@"call19")]
            public float[] Call19 { get; set; }

            [ColumnName(@"20")]
            public float _20 { get; set; }

            [ColumnName(@"call20")]
            public float[] Call20 { get; set; }

            [ColumnName(@"21")]
            public float _21 { get; set; }

            [ColumnName(@"call21")]
            public float[] Call21 { get; set; }

            [ColumnName(@"22")]
            public float _22 { get; set; }

            [ColumnName(@"call22")]
            public float[] Call22 { get; set; }

            [ColumnName(@"23")]
            public float _23 { get; set; }

            [ColumnName(@"call23")]
            public float[] Call23 { get; set; }

            [ColumnName(@"24")]
            public float _24 { get; set; }

            [ColumnName(@"call24")]
            public float[] Call24 { get; set; }

            [ColumnName(@"25")]
            public float _25 { get; set; }

            [ColumnName(@"call25")]
            public float[] Call25 { get; set; }

            [ColumnName(@"26")]
            public float _26 { get; set; }

            [ColumnName(@"call26")]
            public float[] Call26 { get; set; }

            [ColumnName(@"27")]
            public float _27 { get; set; }

            [ColumnName(@"call27")]
            public float[] Call27 { get; set; }

            [ColumnName(@"34")]
            public float _34 { get; set; }

            [ColumnName(@"call28")]
            public float[] Call28 { get; set; }

            [ColumnName(@"35")]
            public float _35 { get; set; }

            [ColumnName(@"call29")]
            public float[] Call29 { get; set; }

            [ColumnName(@"36")]
            public float _36 { get; set; }

            [ColumnName(@"call30")]
            public float[] Call30 { get; set; }

            [ColumnName(@"37")]
            public float _37 { get; set; }

            [ColumnName(@"call31")]
            public float[] Call31 { get; set; }

            [ColumnName(@"38")]
            public float _38 { get; set; }

            [ColumnName(@"call32")]
            public float[] Call32 { get; set; }

            [ColumnName(@"28")]
            public float _28 { get; set; }

            [ColumnName(@"call33")]
            public float[] Call33 { get; set; }

            [ColumnName(@"29")]
            public float _29 { get; set; }

            [ColumnName(@"call34")]
            public float[] Call34 { get; set; }

            [ColumnName(@"30")]
            public float _30 { get; set; }

            [ColumnName(@"call35")]
            public float[] Call35 { get; set; }

            [ColumnName(@"31")]
            public float _31 { get; set; }

            [ColumnName(@"call36")]
            public float[] Call36 { get; set; }

            [ColumnName(@"32")]
            public float _32 { get; set; }

            [ColumnName(@"call37")]
            public float[] Call37 { get; set; }

            [ColumnName(@"33")]
            public float _33 { get; set; }

            [ColumnName(@"call38")]
            public float[] Call38 { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"PredictedLabel")]
            public string PredictedLabel { get; set; }

            [ColumnName(@"Score")]
            public float[] Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("CancerClassification.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
