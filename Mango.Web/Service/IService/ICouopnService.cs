using Mango.Web.Models;

namespace Mango.Web.Service.IService;

public interface ICouopnService
{
    Task<ResponseDto?> GetCouponAsync(string couponCode);
    Task<ResponseDto?> GetAllCouponsAsync();
    Task<ResponseDto?> GetCouponByIdAsync(int id);
    Task<ResponseDto?> CreateCouponsAsync(CouponDto couponDTO);
    Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponDTO);
    Task<ResponseDto?> DeleteCouponsAsync(int id);
}
