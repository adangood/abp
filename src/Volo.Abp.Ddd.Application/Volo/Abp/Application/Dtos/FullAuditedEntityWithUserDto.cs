using System;
using Volo.Abp.Auditing;

namespace Volo.Abp.Application.Dtos
{
    /// <summary>
    /// This class can be inherited by DTO classes to implement <see cref="IFullAudited{TUser}"/> interface.
    /// </summary>
    /// <typeparam name="TUserDto">Type of the User</typeparam>
    [Serializable]
    public abstract class FullAuditedEntityWithUserDto<TUserDto> : FullAuditedEntityDto, IFullAudited<TUserDto>
    {
        /// <inheritdoc />
        public TUserDto CreatorUser { get; set; }

        /// <inheritdoc />
        public TUserDto LastModifierUser { get; set; }

        /// <inheritdoc />
        public TUserDto DeleterUser { get; set; }
    }

    /// <summary>
    /// This class can be inherited by DTO classes to implement <see cref="IFullAudited{TUser}"/> interface.
    /// </summary>
    /// <typeparam name="TPrimaryKey">Type of primary key</typeparam>
    /// <typeparam name="TUserDto">Type of the User</typeparam>
    [Serializable]
    public abstract class FullAuditedEntityWithUserDto<TPrimaryKey, TUserDto> : FullAuditedEntityDto<TPrimaryKey>, IFullAudited<TUserDto>
    {
        /// <inheritdoc />
        public TUserDto CreatorUser { get; set; }
        
        /// <inheritdoc />
        public TUserDto LastModifierUser { get; set; }
        
        /// <inheritdoc />
        public TUserDto DeleterUser { get; set; }
    }
}