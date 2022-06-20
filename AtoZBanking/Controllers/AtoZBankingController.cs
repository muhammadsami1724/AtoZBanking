using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtoZBanking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtoZBanking.Controllers
{
    public class AtoZBankingController : Controller
    {
        private readonly AtoZBankingDBContext _context;

        public AtoZBankingController(AtoZBankingDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Accounts()
        {
            var accounts =  await _context.Accounts.ToListAsync();
            ViewBag.alert = TempData["alert"] as string;
            return View(accounts);
        }
        public async Task<IActionResult> Home()
        {
            return View();
        }
        public async Task<IActionResult> InitiateTransfer()
        {
            var accounts = await _context.Accounts.ToListAsync();
            ViewBag.Accounts = accounts;
            ViewBag.alert = TempData["alert"] as string;
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> InitiateTransfer(Transactions trasaction)
        {
            if(trasaction.FromAccount == trasaction.ToAccount)
            {
                TempData["alert"] = "you cant send amount to same accounts";
                return RedirectToAction("InitiateTransfer");
            }
            var FAccount = await _context.Accounts.Where(c => c.AccountId == Convert.ToInt32(trasaction.FromAccount)).FirstOrDefaultAsync();
            var TAccount = await _context.Accounts.Where(c => c.AccountId == Convert.ToInt32(trasaction.ToAccount)).FirstOrDefaultAsync();
            Transactions trans = new Transactions();
            trans.FromAccount = FAccount.AccountName;
            trans.ToAccount = TAccount.AccountName;
            trans.AmountDebited = trasaction.AmountDebited;
            trans.TransactionDate = DateTime.UtcNow;
            trans.FromAccountBalance = FAccount.Balance;
            trans.ToAccountBalance = TAccount.Balance;
            _context.Transactions.Add(trans);
            _context.SaveChanges();
            FAccount.Balance = FAccount.Balance - trasaction.AmountDebited;
            _context.Accounts.Update(FAccount);
            _context.SaveChanges();
            TAccount.Balance = TAccount.Balance + trasaction.AmountDebited;
            _context.Accounts.Update(TAccount);
            _context.SaveChanges();
            TempData["alert"] = "Amount has been transferred successfully";
            return RedirectToAction("TransactionDetails");
        }
        public async Task<IActionResult> TransactionDetails()
        {
            var Transactions = await _context.Transactions.ToListAsync();
            ViewBag.alert = TempData["alert"] as string;
            return View(Transactions);
        }
        public async Task<IActionResult> Edit(int AccountId)
        {
            var accounts = await _context.Accounts.Where(c=>c.AccountId==AccountId).FirstOrDefaultAsync();
            ViewBag.alert = TempData["alert"] as string;
            return View(accounts);
        }

        [HttpPost]
        [ActionName("Edit")]
        public async Task<IActionResult> EditPost(int Id, Accounts accountDetails)
        {
            if (accountDetails.AccountName != null)
            {
                var account = await _context.Accounts.Where(c => c.AccountId == Id).FirstOrDefaultAsync();
                account.AccountName = accountDetails.AccountName;
                account.Balance = accountDetails.Balance;
                _context.Accounts.Update(account);
                _context.SaveChanges();
                TempData["alert"] =  "Account updated successfully";
                return RedirectToAction("Accounts");
            }
            else
            {
                TempData["alert"] = "Enter Account Name";
                return RedirectToAction("Edit");
            }
                
        }
        public async Task<IActionResult> Details(int AccountId)
        {
            var accounts = await _context.Accounts.Where(c => c.AccountId == AccountId).FirstOrDefaultAsync();
            return View(accounts);
        }
        public async Task<IActionResult> Delete(int AccountId)
        {
            var accounts = await _context.Accounts.Where(c => c.AccountId == AccountId).FirstOrDefaultAsync();
            return View(accounts);
        }
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int Id)
        {
            var account = await _context.Accounts.Where(c => c.AccountId == Id).FirstOrDefaultAsync();
            _context.Accounts.Remove(account);
            _context.SaveChanges();
            TempData["alert"] = "Account deleted successfully";
            return RedirectToAction("Accounts");
        }
        public IActionResult Create()
        {
            ViewBag.alert = TempData["alert"] as string;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Accounts accountDetails)
        {
            Accounts newAccount = new Accounts();
            newAccount.AccountName = accountDetails.AccountName;
            newAccount.Balance = accountDetails.Balance;
            _context.Accounts.Add(newAccount);
            _context.SaveChanges();
            TempData["alert"] = "Account created successfully";
            
            return RedirectToAction("Accounts");
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}