import { IImage } from './i-image';
import { IPrice } from './i-price';
import { ISpecification } from './i-specification';


export interface IProduct {
    id: number,
    productName: string,
    description: string,
    images: IImage[],
    category: string,
    categoryId: number,
    price: IPrice,
    specifications: ISpecification[]
}
