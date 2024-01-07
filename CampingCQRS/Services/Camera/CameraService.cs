using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainServices;
using Model;

namespace Services.Camera
{
    public class CameraService
    {
        private IUnitOfWork _unitOfWork;
        public CameraService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}