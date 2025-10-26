using Mango.Web.Models;

namespace Mango.Web.Service.IService;

public interface ICouopnService
{
    Task<ResponseDto?> GetCouponAsync(string couponCode);
    Task<ResponseDto?> GetAllCouponsAsync();
    Task<ResponseDto?> GetCouponByIdAsync(int id);
    Task<ResponseDto?> CreateCouponsAsync(CouponDTO couponDTO);
    Task<ResponseDto?> UpdateCouponsAsync(CouponDTO couponDTO);
    Task<ResponseDto?> DeleteCouponsAsync(int id);
}
