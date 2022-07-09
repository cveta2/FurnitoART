import { IOrderItem } from './i-order-item';

export interface INewOrder {
    address: string,
    city: string,
    country: string,
    phone: string,
    orderItems: IOrderItem[],
    orderNumber?: number
}
