﻿using AutoMapper;
using BB20_InteriorCategories.Models;
using BB20_InteriorCategories.Models.DTOs;
using BB20_InteriorCategories.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BB20_InteriorCategories.Repository.Services;

public class InteriorCategoryRepository : IinteriorCategoryRepository
{
    private readonly BB20_InteriorCategoriesContext _context;
    private readonly IMapper _mapper;

    public InteriorCategoryRepository(BB20_InteriorCategoriesContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<InteriorCategoryDTO>> GetAll()
    {
        List<InteriorCategory> interiorCategories = await _context.InteriorCategories
                                            .Where(x => x.DeleteFlag == false)
                                            .AsNoTracking()
                                            .ToListAsync();

        return _mapper.Map<List<InteriorCategoryDTO>>(interiorCategories);
    }

    public async Task<List<DropDownDTO>> GetAllForDropDown()
    {
        List<InteriorCategory> interiorCategories = await _context.InteriorCategories
                                    .Where(x => x.DeleteFlag == false)
                                    .Select(s => new InteriorCategory
                                    {
                                        InteriorCategoryId = s.InteriorCategoryId,
                                        Name = s.Name
                                    })
                                    .AsNoTracking()
                                    .ToListAsync();

        return _mapper.Map<List<DropDownDTO>>(interiorCategories);
    }

    public async Task<InteriorCategoryDTO> GetDataById(int interiorCategoryId)
    {
        InteriorCategory? interiorCategories = await _context.InteriorCategories
                                            .Where(x => x.DeleteFlag == false && x.InteriorCategoryId == interiorCategoryId)
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync();

        return _mapper.Map<InteriorCategoryDTO>(interiorCategories);
    }

    public async Task<List<InteriorCategoryDTO>> GetDataBySubCategoryId(int subCategoryId)
    {
        List<InteriorCategory> interiorCategories = await _context.InteriorCategories
                                    .Where(x => x.DeleteFlag == false && x.SubCategoryId == subCategoryId)
                                    .AsNoTracking()
                                    .ToListAsync();

        return _mapper.Map<List<InteriorCategoryDTO>>(interiorCategories);
    }

    public async Task<int> AddAsync(InteriorCategoryDTO entity)
    {
        try
        {
            InteriorCategory interiorCategory = _mapper.Map<InteriorCategoryDTO, InteriorCategory>(entity);

            interiorCategory.DeleteFlag = false;
            interiorCategory.CreatedDate = DateTime.Now;
            interiorCategory.UpdatedDate = DateTime.Now;

            _context.InteriorCategories.Add(interiorCategory);
            await _context.SaveChangesAsync();

            return interiorCategory.InteriorCategoryId;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> UpdateAsync(InteriorCategoryDTO entity)
    {
        try
        {
            InteriorCategory interiorCategory = _mapper.Map<InteriorCategoryDTO, InteriorCategory>(entity);

            interiorCategory.UpdatedDate = DateTime.Now;
            interiorCategory.DeleteFlag = false;

            _context.InteriorCategories.Update(interiorCategory);
            await _context.SaveChangesAsync();
            return true;

        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> RemoveAsync(int interiorCategoryId)
    {
        try
        {
            InteriorCategory? interiorCategory = _context.InteriorCategories
                                .Where(x => x.InteriorCategoryId == interiorCategoryId)
                                .FirstOrDefault();

            if (interiorCategory == null)
            {
                return false;
            }

            interiorCategory.UpdatedDate = DateTime.Now;
            interiorCategory.DeleteFlag = true;

            _context.InteriorCategories.Update(interiorCategory);
            await _context.SaveChangesAsync();

            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
