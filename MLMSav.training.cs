﻿﻿// This file was auto-generated by ML.NET Model Builder. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;
using Microsoft.ML;

namespace MachineLearning
{
    public partial class MLMSav
    {
        /// <summary>
        /// Retrains model using the pipeline generated as part of the training process. For more information on how to load data, see aka.ms/loaddata.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <param name="trainData"></param>
        /// <returns></returns>
        public static ITransformer RetrainPipeline(MLContext mlContext, IDataView trainData)
        {
            var pipeline = BuildPipeline(mlContext);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.Categorical.OneHotEncoding(new []{new InputOutputColumnPair(@"Element", @"Element"),new InputOutputColumnPair(@"weapon_type", @"weapon_type")}, outputKind: OneHotEncodingEstimator.OutputKind.Indicator)      
                                    .Append(mlContext.Transforms.ReplaceMissingValues(@"gun_RoF", @"gun_RoF"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"gun_name",outputColumnName:@"gun_name"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"gun_archetype",outputColumnName:@"gun_archetype"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Source",outputColumnName:@"Source"))      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"Element",@"weapon_type",@"gun_RoF",@"gun_name",@"gun_archetype",@"Source"}))      
                                    .Append(mlContext.Transforms.Conversion.MapValueToKey(outputColumnName:@"Rarity",inputColumnName:@"Rarity"))      
                                    .Append(mlContext.Transforms.NormalizeMinMax(@"Features", @"Features"))      
                                    .Append(mlContext.MulticlassClassification.Trainers.OneVersusAll(binaryEstimator: mlContext.BinaryClassification.Trainers.LbfgsLogisticRegression(new LbfgsLogisticRegressionBinaryTrainer.Options(){L1Regularization=0.03125F,L2Regularization=0.3259713F,LabelColumnName=@"Rarity",FeatureColumnName=@"Features"}), labelColumnName:@"Rarity"))      
                                    .Append(mlContext.Transforms.Conversion.MapKeyToValue(outputColumnName:@"PredictedLabel",inputColumnName:@"PredictedLabel"));

            return pipeline;
        }
    }
}
