using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleAssembleSteps;

namespace VehicleAssembleSteps_TestCases
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test_AddVehicleAssembleMethod()
        {
            int result;
            VehicleAssembleModel vehicleAssembleModel = new VehicleAssembleModel();
            Repository repository = new Repository();
            vehicleAssembleModel.AssemblyProcess = "Test AssembleProcess";
            vehicleAssembleModel.ColorCode = "Red";
            vehicleAssembleModel.Region = "North";
            vehicleAssembleModel.TirePressure = 13;
            vehicleAssembleModel.TransmissionType = "AMT";
            vehicleAssembleModel.Variant = "Domestic";
            vehicleAssembleModel.VehicleProjectCode = "TestPro123";
            result = repository.AddVehicleAssemble(vehicleAssembleModel);
            Assert.AreEqual(result, 1);

            vehicleAssembleModel.AssemblyProcess = " ";
            vehicleAssembleModel.ColorCode = "";
            vehicleAssembleModel.Region = "";
            vehicleAssembleModel.TirePressure = 0;
            vehicleAssembleModel.TransmissionType = "";
            vehicleAssembleModel.Variant = "";
            vehicleAssembleModel.VehicleProjectCode = "";
            Assert.AreEqual(result, 1);
        }
    }
}
