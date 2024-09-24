using DensityPeaksClustering;
using Microsoft.AspNetCore.Mvc;

namespace DensityPeaksClusteringService.Controllers
{
    public class DensityPeaksClusteringController : Controller
    {
        [HttpPost("MultiManifold")]
        public IActionResult MultiManifold([FromBody] float[][] mat, int k, int M, ClusterCentersTuningType tuningType, DistanceFunctionType distanceType)
        {
            var result = DensityPeaksClusteringAlgorithms.MultiManifold( mat, k, M, tuningType, distanceType);
            return Ok(result);
        }


        [HttpPost("KNN")]
        public IActionResult KNN([FromBody] float[][] mat, int k, ClusterCentersTuningType tuningType, DistanceFunctionType distanceType)
        {
            var result = DensityPeaksClusteringAlgorithms.KNN(mat, k, tuningType, distanceType);
            return Ok(result);
        }

        /*

        [HttpPost]
        [Route("DPClustering/{cutoffDistance}/{distanceType}")]
        public int[] DPClustering([FromBody] DataMatrix<float> m, double cutoffDistance,
            DistanceFunctionType distanceType = DistanceFunctionType.EuclideanDistance)
        {
            return DensityPeaksClusteringAlgorithms.DPClustering(m.Matrix, cutoffDistance, distanceType);
        }


        //Functions From Distance Matrix:

        [HttpPost]
        [Route("DPClusteringFromDistanceMatrix/{cutoffDistance}")]
        public int[] DPClusteringFromDistanceMatrix([FromBody] DistanceMatrix dMatrix, double cutoffDistance)
        {
            return DensityPeaksClusteringAlgorithms.DPClusteringFromDistanceMatrix(dMatrix, cutoffDistance);

        }

        [HttpPost]
        [Route("DPClusteringWithKNNFromDistanceMatrix")]
        public int[] DPClusteringWithKNNFromDistanceMatrix([FromBody] DistanceMatrix dMatrix)
        {
            return DensityPeaksClusteringAlgorithms.DPClusteringWithKNNFromDistanceMatrix(dMatrix);
        }

        [HttpPost]
        [Route("DPClusteringWithMultiManifoldFromDistanceMatrix")]
        public int[] DPClusteringWithMultiManifoldFromDistanceMatrix([FromBody] DistanceMatrix dMatrix)
        {
            return DensityPeaksClusteringAlgorithms.DPClusteringWithMultiManifoldFromDistanceMatrix(dMatrix);
        }
        */
    }
}
