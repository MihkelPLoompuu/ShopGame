﻿using Microsoft.Extensions.Hosting;
using Shop.Core.Domain;
using Shop.Core.Dto;
using Store.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ApplicationServices.Services
{
    public class FileServices : IFileServices
    {
        private readonly IHostEnvironment  _webHost;
        private readonly ShopContext  _context;

        public FileServices
            (
                IHostEnvironment webHost,
                ShopContext  context
            )
        {
            _webHost = webHost;
            _context = context;
        }
        public void UploadFilesToDatavbse(ShopDto dto, Shop domain)
        {
            if(dto.Files != null && dto.Files.Count > 0)
            {
                foreach(var image in dto.Files)
                {
                    using(var target = new MemoryStream())
                    {
                        FileToDatabase files = new FileToDatabase()
                        {
                            ID = Guid.NewGuid(),
                            ImageTitle = image.FileName,
                            ShopID = domain.Id,
                        };
                        image.CopyTo( target );
                        files.ImageDate = target.ToArray();
                        _context.FilesToDatabase.Add(files);
                    }
                }
            }
        }
    }
}