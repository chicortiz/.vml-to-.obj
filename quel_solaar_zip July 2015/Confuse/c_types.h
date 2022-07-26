typedef enum{
	C_DPT_DRAW_CALL_UNIFORM, // draw multiple object using multiple drawcalls with static vertex date
	C_DPT_DRAW_CALL_ATTRIBUTE, // draw a single drawcall with dynamicaly generated vertexx data
	C_DPT_COUNT
}CDrawStateType;

#define C_PARTICLES

typedef enum{
	C_TYPE_FLOAT,
	C_TYPE_UV,
	C_TYPE_POS,
	C_TYPE_COLOR,
	C_TYPE_MATRIX,
	C_TYPE_AREA,
	C_TYPE_POS_QUATERNION_SIZE,
	C_TYPE_UV_SECTION,
	C_TYPE_SAME_FLOAT_AS_OUTPUT,
	C_TYPE_IMAGE_2D,
	C_TYPE_IMAGE_3D,
	C_TYPE_IMAGE_CUBE,
	C_TYPE_OBJECT,
	C_TYPE_STATE_DEPTH_TEST,
	C_TYPE_STATE_BLEND_SOURCE,
	C_TYPE_STATE_BLEND_DESTINATION,
	C_TYPE_PARTICLE,
	C_TYPE_BOOLEAN,
	C_TYPE_COUNT
}CTypeType;

#define C_TYPE_INTEGER_START C_TYPE_IMAGE_2D