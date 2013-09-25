﻿using System.Collections.Generic;
using System;

namespace Domas.Web.Mvc.Examples.Models
{
    public partial class ChartDataRepository
    {
        public static IList<BudgetReportItem> BudgetReport() 
        {
            return new BudgetReportItem[] {
                new BudgetReportItem("Sales", 40000, 52800),
                new BudgetReportItem("Marketing", 20000, 42000),
                new BudgetReportItem("Development", 60000, 21400),
                new BudgetReportItem("Customer Support", 30000, 28500),
                new BudgetReportItem("IT", 25000, 18900),
                new BudgetReportItem("Administration", 10000, 11100)
            };
        }

        public static IList<ProteinScoreItem> ProteinQualityData()
        {
            return new ProteinScoreItem[] {
                new ProteinScoreItem("Tryptophan", "Trp", 3),
                new ProteinScoreItem("Threonine", "Thr", 4),
                new ProteinScoreItem("Isoleucine", "Iso", 5),
                new ProteinScoreItem("Leucine", "Leu", 5),
                new ProteinScoreItem("Lysine", "Lys", 5),
                new ProteinScoreItem("Methionine + Cystine", "M+C", 2),
                new ProteinScoreItem("Phenylalanine + Tyrosine", "p+T", 3),
                new ProteinScoreItem("Valine", "Val", 5),
                new ProteinScoreItem("Histidine", "Hys", 4)
            };
        }

        public static IList<WindDataItem> WindData()
        {
            return new WindDataItem[] {
                new WindDataItem(0, "N", "< 0.5", 0),
                new WindDataItem(0, "N", "0.5 to 2", 2),
                new WindDataItem(0, "N", "2 to 4", 3),
                new WindDataItem(0, "N", "4 to 6", 2.5),
                new WindDataItem(0, "N", "6 to 8", 1),
                new WindDataItem(0, "N", "8 to 10", 0.5),
                new WindDataItem(0, "N", "> 10", 0.1),
                new WindDataItem(1, "NNE", "< 0.5", 0),
                new WindDataItem(1, "NNE", "0.5 to 2", 0.1),
                new WindDataItem(1, "NNE", "2 to 4", 0.1),
                new WindDataItem(1, "NNE", "4 to 6", 0),
                new WindDataItem(1, "NNE", "6 to 8", 0),
                new WindDataItem(1, "NNE", "8 to 10", 0),
                new WindDataItem(1, "NNE", "> 10", 0),
                new WindDataItem(2, "NE", "< 0.5", 0),
                new WindDataItem(2, "NE", "0.5 to 2", 0.2),
                new WindDataItem(2, "NE", "2 to 4", 0),
                new WindDataItem(2, "NE", "4 to 6", 0),
                new WindDataItem(2, "NE", "6 to 8", 0),
                new WindDataItem(2, "NE", "8 to 10", 0),
                new WindDataItem(2, "NE", "> 10", 0),
                new WindDataItem(3, "ENE", "< 0.5", 0),
                new WindDataItem(3, "ENE", "0.5 to 2", 0.2),
                new WindDataItem(3, "ENE", "2 to 4", 0.1),
                new WindDataItem(3, "ENE", "4 to 6", 0),
                new WindDataItem(3, "ENE", "6 to 8", 0),
                new WindDataItem(3, "ENE", "8 to 10", 0),
                new WindDataItem(3, "ENE", "> 10", 0),
                new WindDataItem(4, "E", "< 0.5", 0),
                new WindDataItem(4, "E", "0.5 to 2", 0.2),
                new WindDataItem(4, "E", "2 to 4", 0.3),
                new WindDataItem(4, "E", "4 to 6", 0),
                new WindDataItem(4, "E", "6 to 8", 0),
                new WindDataItem(4, "E", "8 to 10", 0),
                new WindDataItem(4, "E", "> 10", 0),
                new WindDataItem(5, "ESE", "< 0.5", 0),
                new WindDataItem(5, "ESE", "0.5 to 2", 0.4),
                new WindDataItem(5, "ESE", "2 to 4", 0.4),
                new WindDataItem(5, "ESE", "4 to 6", 0.1),
                new WindDataItem(5, "ESE", "6 to 8", 0.1),
                new WindDataItem(5, "ESE", "8 to 10", 0),
                new WindDataItem(5, "ESE", "> 10", 0),
                new WindDataItem(6, "SE", "< 0.5", 0),
                new WindDataItem(6, "SE", "0.5 to 2", 0.8),
                new WindDataItem(6, "SE", "2 to 4", 1.4),
                new WindDataItem(6, "SE", "4 to 6", 1.4),
                new WindDataItem(6, "SE", "6 to 8", 1),
                new WindDataItem(6, "SE", "8 to 10", 0.1),
                new WindDataItem(6, "SE", "> 10", 0),
                new WindDataItem(7, "SSE", "< 0.5", 0.1),
                new WindDataItem(7, "SSE", "0.5 to 2", 6),
                new WindDataItem(7, "SSE", "2 to 4", 2),
                new WindDataItem(7, "SSE", "4 to 6", 0.8),
                new WindDataItem(7, "SSE", "6 to 8", 0.5),
                new WindDataItem(7, "SSE", "8 to 10", 0),
                new WindDataItem(7, "SSE", "> 10", 0),
                new WindDataItem(8, "S", "< 0.5", 0.2),
                new WindDataItem(8, "S", "0.5 to 2", 10),
                new WindDataItem(8, "S", "2 to 4", 1),
                new WindDataItem(8, "S", "4 to 6", 0),
                new WindDataItem(8, "S", "6 to 8", 0),
                new WindDataItem(8, "S", "8 to 10", 0),
                new WindDataItem(8, "S", "> 10", 0),
                new WindDataItem(9, "SSW", "< 0.5", 0.1),
                new WindDataItem(9, "SSW", "0.5 to 2", 8),
                new WindDataItem(9, "SSW", "2 to 4", 1),
                new WindDataItem(9, "SSW", "4 to 6", 0),
                new WindDataItem(9, "SSW", "6 to 8", 0),
                new WindDataItem(9, "SSW", "8 to 10", 0),
                new WindDataItem(9, "SSW", "> 10", 0),
                new WindDataItem(10, "SW", "< 0.5", 0),
                new WindDataItem(10, "SW", "0.5 to 2", 6),
                new WindDataItem(10, "SW", "2 to 4", 3),
                new WindDataItem(10, "SW", "4 to 6", 1),
                new WindDataItem(10, "SW", "6 to 8", 0.1),
                new WindDataItem(10, "SW", "8 to 10", 0),
                new WindDataItem(10, "SW", "> 10", 0),
                new WindDataItem(11, "WSW", "< 0.5", 0),
                new WindDataItem(11, "WSW", "0.5 to 2", 3),
                new WindDataItem(11, "WSW", "2 to 4", 4),
                new WindDataItem(11, "WSW", "4 to 6", 1),
                new WindDataItem(11, "WSW", "6 to 8", 0),
                new WindDataItem(11, "WSW", "8 to 10", 0),
                new WindDataItem(11, "WSW", "> 10", 0),
                new WindDataItem(12, "W", "< 0.5", 0),
                new WindDataItem(12, "W", "0.5 to 2", 2),
                new WindDataItem(12, "W", "2 to 4", 3),
                new WindDataItem(12, "W", "4 to 6", 1),
                new WindDataItem(12, "W", "6 to 8", 0),
                new WindDataItem(12, "W", "8 to 10", 0),
                new WindDataItem(12, "W", "> 10", 0.1),
                new WindDataItem(13, "WNW", "< 0.5", 0),
                new WindDataItem(13, "WNW", "0.5 to 2", 1),
                new WindDataItem(13, "WNW", "2 to 4", 5),
                new WindDataItem(13, "WNW", "4 to 6", 2),
                new WindDataItem(13, "WNW", "6 to 8", 0.5),
                new WindDataItem(13, "WNW", "8 to 10", 0),
                new WindDataItem(13, "WNW", "> 10", 0.1),
                new WindDataItem(14, "NW", "< 0.5", 0),
                new WindDataItem(14, "NW", "0.5 to 2", 2),
                new WindDataItem(14, "NW", "2 to 4", 5),
                new WindDataItem(14, "NW", "4 to 6", 2),
                new WindDataItem(14, "NW", "6 to 8", 1),
                new WindDataItem(14, "NW", "8 to 10", 0.1),
                new WindDataItem(14, "NW", "> 10", 0.1),
                new WindDataItem(15, "NNW", "< 0.5", 0),
                new WindDataItem(15, "NNW", "0.5 to 2", 4),
                new WindDataItem(15, "NNW", "2 to 4", 5),
                new WindDataItem(15, "NNW", "4 to 6", 5),
                new WindDataItem(15, "NNW", "6 to 8", 3),
                new WindDataItem(15, "NNW", "8 to 10", 1),
                new WindDataItem(15, "NNW", "> 10", 0.2)
            };
        }
    }
}