﻿using SampleArch.Model;
using SampleArch.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Service
{
    public class CountryService : EntityService<Country>, ICountryService
    {
        IUnitOfWork _unitOfWork;
        ICountryRepository _countryRepository;

        public CountryService(IUnitOfWork unitOfWork, ICountryRepository countryRepository)
            : base(unitOfWork, countryRepository)
        {
            _unitOfWork = unitOfWork;
            _countryRepository = countryRepository;
        }

        public Country GetById(int id)
        {
            return _countryRepository.GetById(id);
        }
    }
}
