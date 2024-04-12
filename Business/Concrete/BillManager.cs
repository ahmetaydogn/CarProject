using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidator;
using Core.Utilities.Results;
using Core.Utilities.Validation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class BillManager : IBillService
{
    private readonly IBillDal _billDal;
    public BillManager(IBillDal billDal)
    {
        _billDal = billDal;
    }

    public IResult Add(Bill bill)
    {
        ValidationTool<Bill>.Validate(new BillValidator(), bill);

        _billDal.Add(bill);
        return new SuccessResult(Messages.BillAdded);
    }

    public IResult Update(Bill bill)
    {
        ValidationTool<Bill>.Validate(new BillValidator(), bill);

        _billDal.Update(bill);
        return new SuccessResult(Messages.BillUpdated);
    }

    public IResult Delete(Bill bill)
    {
        _billDal.Delete(bill);
        return new SuccessResult(Messages.BillDeleted);
    }

    public IDataResult<List<Bill>> GetAll()
    {
        var result = _billDal.GetAll().ToList();
        return new SuccessDataResult<List<Bill>>(result);
    }

    public IDataResult<List<Bill>> GetAllBySale(int saleId)
    {
        var result = _billDal.GetAll(p => p.SaleId == saleId).ToList();
        return new SuccessDataResult<List<Bill>>(result);
    }

    public IDataResult<Bill> GetById(int id)
    {
        var result = _billDal.Get(p => p.BillId == id);
        return new SuccessDataResult<Bill>(result);
    }
}
