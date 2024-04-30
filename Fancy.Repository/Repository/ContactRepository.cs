using Fancy.Models.Items;
using FANCY_CLOTHES_MANAGEMENT.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Repository.Repository
{
    public class ContactRepository
    {
                    private readonly ApplicationDbContext _context;

            public ContactRepository(ApplicationDbContext context)
            {
                _context = context;
            }

            public IEnumerable<Contact> GetAllContacts()
            {
                return _context.Contact.ToList();
            }

            public Contact GetContactById(int id)
            {
                return _context.Contact.FirstOrDefault(c => c.ContactId == id);
            }

            public void AddContact(Contact contact)
            {
                _context.Contact.Add(contact);
                _context.SaveChanges();
            }

            public void UpdateContact(Contact contact)
            {
                _context.Entry(contact).State = EntityState.Modified;
                _context.SaveChanges();
            }

            public void DeleteContact(Contact contact)
            {
                _context.Contact.Remove(contact);
                _context.SaveChanges();
            }
        }
    }
