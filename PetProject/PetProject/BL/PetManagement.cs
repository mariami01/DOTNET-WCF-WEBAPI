using DTO;
using PetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace PetProject.BL
{
    public class PetManagement
    {
        public static Response GetPets(int pageNumber = 1, int pageSize = 3)
        {
            try
            {
                using (PetModel db = new PetModel())
                {
                    var query = db.Pets.Select(p => new PetDTO
                    {
                        Name = p.Name,
                        Gender = p.Gender,
                        Color = p.Color,
                        Age = p.Age,
                        Description = p.Description,
                        Characteristic = p.Characteristic,
                        Species = p.Species,
                        Weight = p.Weight,
                        Location = p.Location,
                        AddedBy = p.AddedBy,
                        IsAdopted = p.IsAdopted,
                        AddedDate = p.AddedDate
                    });

                    int totalItems = query.Count();
                    List<PetDTO> pets = query
                        .OrderBy(p => p.Name)
                        .Skip((pageNumber - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

                    return new Response
                    {
                        Success = true,
                        Message = "Pets retrieved successfully",
                        Object = pets,
                        TotalItems = totalItems,
                        PageNumber = pageNumber,
                        PageSize = pageSize
                    };
                }
            }
            catch (Exception e)
            {
                return new Response
                {
                    Success = false,
                    Message = e.Message
                };
            }
        }
        public static Response AddPet(Request<PetDTO> request, UserDTO user)
        {
            PetDTO pet_dto = request.Object;
            try
            {
                using (PetModel db = new PetModel())
                {
                    Pet pet = new Pet()
                    {
                        Name = pet_dto.Name,
                        Description = pet_dto.Description,
                        Age = pet_dto.Age,
                        Characteristic = pet_dto.Characteristic,
                        Color = pet_dto.Color,
                        Gender = pet_dto.Gender,
                        AddedDate = DateTime.Now,
                        IsAdopted = false,
                        Location = pet_dto.Location,
                        Species = pet_dto.Species,
                        Weight = pet_dto.Weight,
                        AddedBy = user.Id
                    };
                    db.Pets.Add(pet);
                    db.SaveChanges();
                }

                return new Response { Success = true, Message = "Pet Added Successfully" };

            } catch (Exception e)
            {
                return new Response { Success = false, Message = e.Message };
            }
        }

        public static Response EditPet(int petId, Request<PetDTO> request, UserDTO user)
        {
            PetDTO pet_dto = request.Object;
            try
            {
                using (PetModel db = new PetModel())
                {
                    var pet = db.Pets.SingleOrDefault(p => p.Id == petId);
                    if (pet == null)
                    {
                        return new Response { Success = false, Message = "Pet not found" };
                    }

                    pet.Name = pet_dto.Name;
                    pet.Description = pet_dto.Description;
                    pet.Age = pet_dto.Age;
                    pet.Characteristic = pet_dto.Characteristic;
                    pet.Color = pet_dto.Color;
                    pet.Gender = pet_dto.Gender;
                    pet.Location = pet_dto.Location;
                    pet.Species = pet_dto.Species;
                    pet.Weight = pet_dto.Weight;

                    db.SaveChanges();

                    return new Response { Success = true, Message = "Pet updated successfully" };
                }
            }
            catch (Exception e)
            {
                return new Response { Success = false, Message = e.Message };
            }
        }

        public static Response DeletePet(int petId, UserDTO user)
        {
            try
            {
                using (PetModel db = new PetModel())
                {
                    var pet = db.Pets.SingleOrDefault(p => p.Id == petId);
                    if (pet == null)
                    {
                        return new Response { Success = false, Message = "Pet not found" };
                    }

                    db.Pets.Remove(pet);
                    db.SaveChanges();

                    return new Response { Success = true, Message = "Pet deleted successfully" };
                }
            }
            catch (Exception e)
            {
                return new Response { Success = false, Message = e.Message };
            }
        }

        public static Response SearchPets(string searchTerm)
        {
            try
            {
                using (PetModel db = new PetModel())
                {
                    var query = db.Pets.Where(p =>
                        p.Name.Contains(searchTerm) ||
                        p.Description.Contains(searchTerm) ||
                        p.Color.Contains(searchTerm) ||
                        p.Gender.Contains(searchTerm) ||
                        p.Species.Contains(searchTerm) ||
                        p.Location.Contains(searchTerm)
                    ).Select(p => new PetDTO
                    {
                        Name = p.Name,
                        Gender = p.Gender,
                        Color = p.Color,
                        Age = p.Age,
                        Description = p.Description,
                        Characteristic = p.Characteristic,
                        Species = p.Species,
                        Weight = p.Weight,
                        Location = p.Location,
                        AddedBy = p.AddedBy,
                        IsAdopted = p.IsAdopted,
                        AddedDate = p.AddedDate
                    }).ToList();

                    return new Response
                    {
                        Success = true,
                        Message = "Pets retrieved successfully",
                        Object = query
                    };
                }
            }
            catch (Exception e)
            {
                return new Response
                {
                    Success = false,
                    Message = e.Message
                };
            }
        }

        public static Response FilterPets(string name, string gender, string color, string species, string location)
        {
            try
            {
                using (PetModel db = new PetModel())
                {
                    var query = db.Pets.AsQueryable();

                    if (!string.IsNullOrEmpty(name))
                    {
                        query = query.Where(p => p.Name.Contains(name));
                    }
                    if (!string.IsNullOrEmpty(gender))
                    {
                        query = query.Where(p => p.Gender == gender);
                    }
                    if (!string.IsNullOrEmpty(color))
                    {
                        query = query.Where(p => p.Color.Contains(color));
                    }
                    if (!string.IsNullOrEmpty(species))
                    {
                        query = query.Where(p => p.Species.Contains(species));
                    }
                    if (!string.IsNullOrEmpty(location))
                    {
                        query = query.Where(p => p.Location.Contains(location));
                    }

                    var pets = query.Select(p => new PetDTO
                    {
                        Name = p.Name,
                        Gender = p.Gender,
                        Color = p.Color,
                        Age = p.Age,
                        Description = p.Description,
                        Characteristic = p.Characteristic,
                        Species = p.Species,
                        Weight = p.Weight,
                        Location = p.Location,
                        AddedBy = p.AddedBy,
                        IsAdopted = p.IsAdopted,
                        AddedDate = p.AddedDate
                    }).ToList();

                    return new Response
                    {
                        Success = true,
                        Message = "Pets filtered successfully",
                        Object = pets
                    };
                }
            }
            catch (Exception e)
            {
                return new Response
                {
                    Success = false,
                    Message = e.Message
                };
            }
        }
    }
}