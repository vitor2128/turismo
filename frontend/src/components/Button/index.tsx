import React from "react";

import { StyledButton } from "./styles";

interface IMyButtonProps {
  label: string;
  variant?: "primary" | "secondary";
  size?: "default" | "small";
  onClick?: React.MouseEventHandler<HTMLButtonElement> | undefined;
  type?: "button" | "submit" | "reset"
}

const Button: React.FC<IMyButtonProps> = ({
  label = "",
  variant = "primary",
  size = "default",
  onClick,
  type,
}) => {
  return (
    <StyledButton type={type} onClick={onClick} variant={variant} size={size}>
      <span>{label}</span>
    </StyledButton>
  );
};

export default Button;
